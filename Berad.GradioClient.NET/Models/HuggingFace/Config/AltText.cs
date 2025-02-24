using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class AltText
    {
        [JsonProperty("anyOf")]
        public List<AnyOf> AnyOf { get; set; }

        [JsonProperty("default")]
        public object Default { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

}