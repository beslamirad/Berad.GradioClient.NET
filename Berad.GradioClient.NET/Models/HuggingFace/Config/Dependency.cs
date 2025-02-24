using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace Berad.GradioClient.NET.Models.HuggingFace.Config{ 

    public class Dependency
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("targets")]
        public List<List<object>> Targets { get; set; }

        [JsonProperty("inputs")]
        public List<int> Inputs { get; set; }

        [JsonProperty("outputs")]
        public List<int> Outputs { get; set; }

        [JsonProperty("backend_fn")]
        public bool BackendFn { get; set; }

        [JsonProperty("js")]
        public object Js { get; set; }

        [JsonProperty("queue")]
        public bool Queue { get; set; }

        [JsonProperty("api_name")]
        public string ApiName { get; set; }

        [JsonProperty("scroll_to_output")]
        public bool ScrollToOutput { get; set; }

        [JsonProperty("show_progress")]
        public string ShowProgress { get; set; }

        [JsonProperty("batch")]
        public bool Batch { get; set; }

        [JsonProperty("max_batch_size")]
        public int MaxBatchSize { get; set; }

        [JsonProperty("cancels")]
        public List<object> Cancels { get; set; }

        [JsonProperty("types")]
        public Types Types { get; set; }

        [JsonProperty("collects_event_data")]
        public bool CollectsEventData { get; set; }

        [JsonProperty("trigger_after")]
        public object TriggerAfter { get; set; }

        [JsonProperty("trigger_only_on_success")]
        public bool TriggerOnlyOnSuccess { get; set; }

        [JsonProperty("trigger_mode")]
        public string TriggerMode { get; set; }

        [JsonProperty("show_api")]
        public bool ShowApi { get; set; }

        [JsonProperty("rendered_in")]
        public object RenderedIn { get; set; }

        [JsonProperty("connection")]
        public string Connection { get; set; }

        [JsonProperty("time_limit")]
        public object TimeLimit { get; set; }

        [JsonProperty("stream_every")]
        public double StreamEvery { get; set; }

        [JsonProperty("like_user_message")]
        public bool LikeUserMessage { get; set; }

        [JsonProperty("event_specific_args")]
        public object EventSpecificArgs { get; set; }
    }

}