using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class File
    {
        [JsonProperty("$ref")]
        public string Ref { get; set; }
    }

}