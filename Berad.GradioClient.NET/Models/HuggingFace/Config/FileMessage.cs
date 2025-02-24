using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class FileMessage
    {
        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("required")]
        public List<string> Required { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}