using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Default
    {
        [JsonProperty("_type")]
        public string Type { get; set; }
    }

}