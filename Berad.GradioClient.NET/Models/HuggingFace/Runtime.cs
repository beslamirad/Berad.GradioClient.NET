using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Models.HuggingFace
{
    public class Runtime
    {
        [JsonProperty("stage")]
        public string Stage { get; set; }

        [JsonProperty("hardware")]
        public Hardware Hardware { get; set; }

        [JsonProperty("storage")]
        public Storage Storage { get; set; }

        [JsonProperty("gcTimeout")]
        public int GcTimeout { get; set; }

        [JsonProperty("replicas")]
        public Replicas Replicas { get; set; }

        [JsonProperty("devMode")]
        public bool DevMode { get; set; }

        [JsonProperty("domains")]
        public List<DomainStage> Domains { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }
    }
}
