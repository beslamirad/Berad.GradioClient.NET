using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class LatexDelimiter
    {
        [JsonProperty("left")]
        public string Left { get; set; }

        [JsonProperty("right")]
        public string Right { get; set; }

        [JsonProperty("display")]
        public bool Display { get; set; }
    }

}