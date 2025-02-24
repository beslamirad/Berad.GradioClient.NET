using Berad.GradioClient.NET.Utils.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Clients
{
    internal class HttpClientManager : IDisposable
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientManager"/> class with a default HttpClient.
        /// </summary>
        public HttpClientManager()
        {
            _httpClient = new HttpClient();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientManager"/> class with a custom HttpClient.
        /// </summary>
        /// <param name="httpClient">An existing HttpClient instance.</param>
        public HttpClientManager(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        /// <summary>
        /// Sends a POST request with a JSON payload.
        /// </summary>
        /// <typeparam name="T">Type of the data to serialize.</typeparam>
        /// <param name="url">The target URL.</param>
        /// <param name="data">The data to send.</param>
        /// <returns>An `IResult<string>` containing the response or an exception.</returns>
        public async Task<IResult<string>> PostAsync<T>(string url, T data)
        {
            return await SendRequestAsync(() =>
            {
                var json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                return _httpClient.PostAsync(url, content);
            });
        }

        /// <summary>
        /// Sends a POST request with a raw string payload.
        /// </summary>
        /// <param name="url">The target URL.</param>
        /// <param name="data">The raw JSON string.</param>
        /// <returns>An `IResult<string>` containing the response or an exception.</returns>
        public async Task<IResult<string>> PostStringAsync(string url, string data)
        {
            return await SendRequestAsync(() =>
            {
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                return _httpClient.PostAsync(url, content);
            });
        }

        /// <summary>
        /// Sends a GET request to the specified URL.
        /// </summary>
        /// <param name="url">The target URL.</param>
        /// <returns>An `IResult<string>` containing the response or an exception.</returns>
        public async Task<IResult<string>> GetAsync(string url)
        {
            return await SendRequestAsync(() => _httpClient.GetAsync(url));
        }

        /// <summary>
        /// Generic method to handle HTTP requests and process responses.
        /// </summary>
        /// <param name="requestFunc">A function returning a Task of HttpResponseMessage.</param>
        /// <returns>An `IResult<string>` containing the response or an exception.</returns>
        private async Task<IResult<string>> SendRequestAsync(Func<Task<HttpResponseMessage>> requestFunc)
        {
            try
            {
                using var response = await requestFunc();
                var responseBody = await response.Content.ReadAsStringAsync();

                return response.IsSuccessStatusCode
                    ? new Result<string>(responseBody)
                    : new Result<string>(false, responseBody, $"HTTP Error: {response.StatusCode}", new Exception(response.ReasonPhrase));
            }
            catch (Exception ex)
            {
                return new Result<string>(ex);
            }
        }

        /// <summary>
        /// Disposes the HttpClient instance.
        /// </summary>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }

}
