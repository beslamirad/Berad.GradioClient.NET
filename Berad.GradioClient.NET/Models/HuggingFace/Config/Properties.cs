using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Properties
    {
        [JsonProperty("component")]
        public Component Component { get; set; }

        [JsonProperty("value")]
        public Value Value { get; set; }

        [JsonProperty("constructor_args")]
        public ConstructorArgs ConstructorArgs { get; set; }

        [JsonProperty("props")]
        public Props Props { get; set; }

        [JsonProperty("path")]
        public Path Path { get; set; }

        [JsonProperty("url")]
        public Url Url { get; set; }

        [JsonProperty("size")]
        public Size Size { get; set; }

        [JsonProperty("orig_name")]
        public OrigName OrigName { get; set; }

        [JsonProperty("mime_type")]
        public MimeType MimeType { get; set; }

        [JsonProperty("is_stream")]
        public IsStream IsStream { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("file")]
        public File File { get; set; }

        [JsonProperty("alt_text")]
        public AltText AltText { get; set; }
    }

}