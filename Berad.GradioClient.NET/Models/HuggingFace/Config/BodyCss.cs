using Newtonsoft.Json; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class BodyCss
    {
        [JsonProperty("body_background_fill")]
        public string BodyBackgroundFill { get; set; }

        [JsonProperty("body_text_color")]
        public string BodyTextColor { get; set; }

        [JsonProperty("body_background_fill_dark")]
        public string BodyBackgroundFillDark { get; set; }

        [JsonProperty("body_text_color_dark")]
        public string BodyTextColorDark { get; set; }
    }

}