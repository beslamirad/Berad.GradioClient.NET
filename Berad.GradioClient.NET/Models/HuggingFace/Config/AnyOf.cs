using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class AnyOf
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

}