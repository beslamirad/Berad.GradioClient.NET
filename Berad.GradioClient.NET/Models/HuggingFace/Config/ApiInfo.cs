using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class ApiInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("$defs")]
        public Defs Defs { get; set; }

        [JsonProperty("items")]
        public Items Items { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("additional_description")]
        public object AdditionalDescription { get; set; }
    }

}