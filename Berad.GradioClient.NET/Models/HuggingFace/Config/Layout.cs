using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Layout
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("children")]
        public List<Child> Children { get; set; }
    }

}