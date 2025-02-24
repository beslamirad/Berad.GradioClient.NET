using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Component
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("props")]
        public Props Props { get; set; }

        [JsonProperty("skip_api")]
        public bool SkipApi { get; set; }

        [JsonProperty("component_class_id")]
        public string ComponentClassId { get; set; }

        [JsonProperty("key")]
        public object Key { get; set; }

        [JsonProperty("api_info")]
        public ApiInfo ApiInfo { get; set; }

        [JsonProperty("api_info_as_input")]
        public ApiInfoAsInput ApiInfoAsInput { get; set; }

        [JsonProperty("api_info_as_output")]
        public ApiInfoAsOutput ApiInfoAsOutput { get; set; }

        [JsonProperty("example_inputs")]
        public object ExampleInputs { get; set; }
    }

}