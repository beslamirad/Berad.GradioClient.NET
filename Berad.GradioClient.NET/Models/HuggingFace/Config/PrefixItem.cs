using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class PrefixItem
    {
        [JsonProperty("anyOf")]
        public List<AnyOf> AnyOf { get; set; }
    }

}