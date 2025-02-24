using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Models.HuggingFace
{
    public class Hardware
    {
        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("requested")]
        public string Requested { get; set; }
    }
}
