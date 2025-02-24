using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Props
    {
        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("show_label")]
        public bool ShowLabel { get; set; }

        [JsonProperty("rtl")]
        public bool Rtl { get; set; }

        [JsonProperty("latex_delimiters")]
        public List<LatexDelimiter> LatexDelimiters { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("elem_classes")]
        public List<object> ElemClasses { get; set; }

        [JsonProperty("sanitize_html")]
        public bool SanitizeHtml { get; set; }

        [JsonProperty("line_breaks")]
        public bool LineBreaks { get; set; }

        [JsonProperty("header_links")]
        public bool HeaderLinks { get; set; }

        [JsonProperty("show_copy_button")]
        public bool ShowCopyButton { get; set; }

        [JsonProperty("container")]
        public bool Container { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_selectable")]
        public bool Selectable { get; set; }

        [JsonProperty("variant")]
        public string Variant { get; set; }

        [JsonProperty("scale")]
        public int? Scale { get; set; }

        [JsonProperty("equal_height")]
        public bool? EqualHeight { get; set; }

        [JsonProperty("show_progress")]
        public bool? ShowProgress { get; set; }

        [JsonProperty("min_width")]
        public int? MinWidth { get; set; }

        [JsonProperty("lines")]
        public int? Lines { get; set; }

        [JsonProperty("max_lines")]
        public int? MaxLines { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("autofocus")]
        public bool? Autofocus { get; set; }

        [JsonProperty("autoscroll")]
        public bool? Autoscroll { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("submit_btn")]
        public bool? SubmitBtn { get; set; }

        [JsonProperty("stop_btn")]
        public bool? StopBtn { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("interactive")]
        public bool? Interactive { get; set; }

        [JsonProperty("_undoable")]
        public bool? Undoable { get; set; }

        [JsonProperty("_retryable")]
        public bool? Retryable { get; set; }

        [JsonProperty("likeable")]
        public bool? Likeable { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("resizeable")]
        public bool? Resizeable { get; set; }

        [JsonProperty("show_share_button")]
        public bool? ShowShareButton { get; set; }

        [JsonProperty("avatar_images")]
        public List<object> AvatarImages { get; set; }

        [JsonProperty("render_markdown")]
        public bool? RenderMarkdown { get; set; }

        [JsonProperty("feedback_options")]
        public List<string> FeedbackOptions { get; set; }

        [JsonProperty("show_copy_all_button")]
        public bool? ShowCopyAllButton { get; set; }

        [JsonProperty("allow_file_downloads")]
        public bool? AllowFileDownloads { get; set; }

        [JsonProperty("group_consecutive_messages")]
        public bool? GroupConsecutiveMessages { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

}