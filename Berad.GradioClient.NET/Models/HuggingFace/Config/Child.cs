using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Child
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("children")]
        public List<Child> Children { get; set; }
    }

}