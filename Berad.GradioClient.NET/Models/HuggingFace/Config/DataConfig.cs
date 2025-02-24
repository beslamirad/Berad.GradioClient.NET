using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class DataConfig
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("api_prefix")]
        public string ApiPrefix { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("dev_mode")]
        public bool DevMode { get; set; }

        [JsonProperty("analytics_enabled")]
        public bool AnalyticsEnabled { get; set; }

        [JsonProperty("components")]
        public List<Component> Components { get; set; }

        [JsonProperty("css")]
        public string Css { get; set; }

        [JsonProperty("connect_heartbeat")]
        public bool ConnectHeartbeat { get; set; }

        [JsonProperty("js")]
        public string Js { get; set; }

        [JsonProperty("head")]
        public string Head { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("space_id")]
        public string SpaceId { get; set; }

        [JsonProperty("enable_queue")]
        public bool EnableQueue { get; set; }

        [JsonProperty("show_error")]
        public bool ShowError { get; set; }

        [JsonProperty("show_api")]
        public bool ShowApi { get; set; }

        [JsonProperty("is_colab")]
        public bool IsColab { get; set; }

        [JsonProperty("max_file_size")]
        public object MaxFileSize { get; set; }

        [JsonProperty("stylesheets")]
        public List<string> Stylesheets { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("body_css")]
        public BodyCss BodyCss { get; set; }

        [JsonProperty("fill_height")]
        public bool FillHeight { get; set; }

        [JsonProperty("fill_width")]
        public bool FillWidth { get; set; }

        [JsonProperty("theme_hash")]
        public string ThemeHash { get; set; }

        [JsonProperty("pwa")]
        public bool Pwa { get; set; }

        [JsonProperty("layout")]
        public Layout Layout { get; set; }

        [JsonProperty("dependencies")]
        public List<Dependency> Dependencies { get; set; }

        [JsonProperty("root")]
        public string Root { get; set; }

        [JsonProperty("username")]
        public object Username { get; set; }
    }

}