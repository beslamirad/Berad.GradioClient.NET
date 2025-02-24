using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Items
    {
        [JsonProperty("maxItems")]
        public int MaxItems { get; set; }

        [JsonProperty("minItems")]
        public int MinItems { get; set; }

        [JsonProperty("prefixItems")]
        public List<PrefixItem> PrefixItems { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

}