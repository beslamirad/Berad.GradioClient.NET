using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Path
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}