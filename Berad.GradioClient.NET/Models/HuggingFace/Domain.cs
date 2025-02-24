using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Models.HuggingFace
{
    public class DomainStage
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("stage")]
        public string Stage { get; set; }
    }
}
