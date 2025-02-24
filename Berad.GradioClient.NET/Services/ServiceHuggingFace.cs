using Berad.GradioClient.NET.Clients;
using Berad.GradioClient.NET.Endpoints;
using Berad.GradioClient.NET.Models.HuggingFace;
using Berad.GradioClient.NET.Models.HuggingFace.Config;
using Berad.GradioClient.NET.Utils.Result;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Services
{
    public class ServiceHuggingFace
    {
        private readonly HttpClientManager _httpClientManager;

        public ServiceHuggingFace()
        {
            _httpClientManager = new HttpClientManager();
        }

        /// <summary>
        /// Retrieves model information from Hugging Face Spaces.
        /// </summary>
        /// <param name="modelName">The name of the target model.</param>
        /// <returns>An instance of `HuggingFaceSpace` containing model details.</returns>
        public Task<IResult<HuggingFaceSpace>> LoadData(string modelName)
        {
            var url = string.Format(HuggingFaceEndpoint.BASE_GET_DATA_SPACE, modelName);
            return FetchData<HuggingFaceSpace>(url);
        }

        /// <summary>
        /// Fetches API configuration settings from a Hugging Face space.
        /// </summary>
        /// <param name="host">The host URL of the target model.</param>
        /// <returns>An instance of `DataConfig` containing API settings.</returns>
        public Task<IResult<DataConfig>> LoadConfig(string host)
        {
            var url = string.Format(HuggingFaceEndpoint.CONFIG, host);
            return FetchData<DataConfig>(url);
        }

        /// <summary>
        /// A generic method to fetch data from the given URL and deserialize it into the specified type.
        /// </summary>
        /// <typeparam name="T">The target type for deserialization.</typeparam>
        /// <param name="url">The API endpoint URL.</param>
        /// <returns>An `IResult<T>` containing either the deserialized object or an error.</returns>
        private async Task<IResult<T>> FetchData<T>(string url) where T : class
        {
            try
            {
                var response = await _httpClientManager.GetAsync(url);
                if (!response.Successed)
                {
                    Console.Error.WriteLine($"[ERROR] FetchData<{typeof(T).Name}>: {response.Exception?.Message}");
                    return new Result<T>(response.Exception);
                }

                var result = JsonConvert.DeserializeObject<T>(response.Value);
                return result != null ? new Result<T>(result) : new Result<T>(new Exception("Failed to deserialize response."));
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"[ERROR] FetchData<{typeof(T).Name}>: {ex.Message}");
                return new Result<T>(ex);
            }
        }
    }

}
