using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Types
    {
        [JsonProperty("generator")]
        public bool Generator { get; set; }

        [JsonProperty("cancel")]
        public bool Cancel { get; set; }
    }

}