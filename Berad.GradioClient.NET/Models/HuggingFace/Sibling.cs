using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Models.HuggingFace
{
    public class Sibling
    {
        [JsonProperty("rfilename")]
        public string Rfilename { get; set; }
    }
}
