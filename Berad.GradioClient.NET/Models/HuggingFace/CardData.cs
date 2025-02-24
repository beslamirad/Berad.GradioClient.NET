using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Models.HuggingFace
{
    public class CardData
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("colorFrom")]
        public string ColorFrom { get; set; }

        [JsonProperty("colorTo")]
        public string ColorTo { get; set; }

        [JsonProperty("sdk")]
        public string Sdk { get; set; }

        [JsonProperty("sdk_version")]
        public string SdkVersion { get; set; }

        [JsonProperty("app_file")]
        public string AppFile { get; set; }

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }
    }
}
