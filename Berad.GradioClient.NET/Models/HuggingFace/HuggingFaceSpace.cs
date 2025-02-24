using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Models.HuggingFace
{
    public class HuggingFaceSpace
    {
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sdk")]
        public string Sdk { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("lastModified")]
        public DateTime LastModified { get; set; }

        [JsonProperty("cardData")]
        public CardData CardData { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("gated")]
        public bool Gated { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("runtime")]
        public Runtime Runtime { get; set; }

        [JsonProperty("siblings")]
        public List<Sibling> Siblings { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("usedStorage")]
        public int UsedStorage { get; set; }
    }
}
