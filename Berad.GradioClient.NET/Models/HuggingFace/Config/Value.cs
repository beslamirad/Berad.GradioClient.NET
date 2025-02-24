using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Value
    {
        [JsonProperty("title")]
        public string Title { get; set; }
    }

}