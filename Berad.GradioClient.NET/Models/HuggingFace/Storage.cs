using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Models.HuggingFace
{
    public class Storage
    {
        [JsonProperty("current")]
        public object Current { get; set; }

        [JsonProperty("requested")]
        public object Requested { get; set; }
    }
}
