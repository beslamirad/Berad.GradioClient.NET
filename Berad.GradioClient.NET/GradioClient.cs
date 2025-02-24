using Berad.GradioClient.NET.Clients;
using Berad.GradioClient.NET.Endpoints;
using Berad.GradioClient.NET.Models.HuggingFace.Config;
using Berad.GradioClient.NET.Services;
using Berad.GradioClient.NET.Utils.Enums;
using Berad.GradioClient.NET.Utils.Result;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET
{
    /// <summary>
    /// The main Client class for the .NET client. This class is used to connect to a remote Gradio app and call its API endpoints.
    /// <br/><br/>
    /// <b>Example:</b>
    /// <code>
    /// // For use huggingface.co space, https://huggingface.co/spaces/Qwen/Qwen2.5-Max-Demo
    /// using Berad.GradioClient.NET;
    /// 
    /// GradioClient client = new GradioClient("Qwen/Qwen2.5-Max-Demo");
    /// 
    /// var requestBodyObject = new
    /// {
    ///     data = new object[]
    ///     {
    ///         "write a method for sum 2 int",
    ///         new object[] {}, 
    ///         "You are an assistant C# programmer."
    ///     }
    /// }; 
    /// 
    /// await client.Predict(requestBodyObject, "/model_chat");
    /// var resultBodyObject = await client.Predict(requestBodyObject, "/model_chat");
    /// if (resultBodyObject.Successed)
    /// {
    ///     Console.WriteLine(resultBodyObject.Value);
    /// }
    /// 
    /// // OR send body as string
    /// var requestBodyString = "{\"data\":[\"write a method for sum 2 int\",[],\"You are an assistant C# programmer.\"]}";
    /// var resultBodyString = await client.Predict(requestBodyString, "/model_chat", Berad.GradioClient.NET.Utils.Enums.PredictBodyType.String);
    /// if (resultBodyString.Successed)
    /// {
    ///     Console.WriteLine(resultBodyString.Value);
    /// }
    /// </code>
    /// </summary>
    public class GradioClient
    {
        private readonly string _modelName;
        private readonly HttpClientManager _httpClientManager;
        private readonly ServiceHuggingFace _huggingFaceService;
        private readonly ServiceDataParse _dataParser;

        private string _host;
        private DataConfig _dataConfig;

        /// <summary>
        /// Initializes a new instance of the <see cref="GradioClient"/> class.
        /// </summary>
        /// <param name="modelName">The name of the target model to be used for API requests.</param>
        public GradioClient(string modelName)
        {
            _modelName = modelName;
            _httpClientManager = new HttpClientManager();
            _huggingFaceService = new ServiceHuggingFace();
            _dataParser = new ServiceDataParse();
        }

        /// <summary>
        /// Sends a request to the specified API endpoint and processes the response.
        /// </summary>
        /// <param name="body">The request payload required for API processing.</param>
        /// <param name="apiName">The API endpoint to call.</param>
        /// <param name="bodyType">The format of the input data (object or string).</param>
        /// <returns>A JSON-formatted string wrapped in an `IResult<string>`.</returns>
        public async Task<IResult<string>> Predict(object body, string apiName, PredictBodyType bodyType = PredictBodyType.Object)
        {
            if (string.IsNullOrWhiteSpace(_host))
            {
                var fillHostResult = await FillHost().ConfigureAwait(false);
                if (!fillHostResult.Successed) return new Result<string>(fillHostResult.Exception);
            }

            var url = BuildApiUrl(apiName);

            try
            {
                var response = bodyType == PredictBodyType.Object
                    ? await _httpClientManager.PostAsync(url, body).ConfigureAwait(false)
                    : await _httpClientManager.PostStringAsync(url, body.ToString()).ConfigureAwait(false);

                if (!response.Successed) return response;

                var responseObject = JsonConvert.DeserializeObject<dynamic>(response.Value);
                string eventId = responseObject?["event_id"];

                return !string.IsNullOrEmpty(eventId)
                    ? await RetrieveData(url, eventId).ConfigureAwait(false)
                    : new Result<string>(false, response.Value, "event_id is missing.", new Exception("event_id is missing."));
            }
            catch (Exception ex)
            {
                return new Result<string>(ex);
            }
        }

        /// <summary>
        /// Retrieves the response data for a given event ID.
        /// </summary>
        private async Task<IResult<string>> RetrieveData(string url, string eventId)
        {
            try
            {
                var response = await _httpClientManager.GetAsync($"{url}/{eventId}").ConfigureAwait(false);
                if (!response.Successed) return new Result<string>(response.Exception);

                var parsedData = _dataParser.Parse(response.Value);
                return string.IsNullOrEmpty(parsedData) ? new Result<string>(response.Value) : new Result<string>(parsedData);
            }
            catch (Exception ex)
            {
                return new Result<string>(ex);
            }
        }

        /// <summary>
        /// Initializes `_host` and `_dataConfig` by fetching model data from Hugging Face.
        /// </summary>
        private async Task<IResult<string>> FillHost()
        {
            try
            {
                var dataSpaceResult = await _huggingFaceService.LoadData(_modelName).ConfigureAwait(false);
                if (!dataSpaceResult.Successed) return new Result<string>(dataSpaceResult.Exception);

                _host = dataSpaceResult.Value.Host;

                var configResult = await _huggingFaceService.LoadConfig(_host).ConfigureAwait(false);
                if (!configResult.Successed) return new Result<string>(configResult.Exception);

                _dataConfig = configResult.Value;
                return new Result<string>(_host);
            }
            catch (Exception ex)
            {
                return new Result<string>(ex);
            }
        }

        /// <summary>
        /// Constructs the complete API endpoint URL.
        /// </summary>
        private string BuildApiUrl(string apiName)
        {
            apiName = apiName.TrimStart('/');
            var apiPrefix = string.IsNullOrWhiteSpace(_dataConfig?.ApiPrefix) ? "" : _dataConfig.ApiPrefix;

            return string.Format(HuggingFaceEndpoint.GRADIO_API, _host, apiPrefix, apiName);
        }
    }


}
