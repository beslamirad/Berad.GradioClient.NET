using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Defs
    {
        [JsonProperty("ComponentMessage")]
        public ComponentMessage ComponentMessage { get; set; }

        [JsonProperty("FileData")]
        public FileData FileData { get; set; }

        [JsonProperty("FileMessage")]
        public FileMessage FileMessage { get; set; }
    }

}