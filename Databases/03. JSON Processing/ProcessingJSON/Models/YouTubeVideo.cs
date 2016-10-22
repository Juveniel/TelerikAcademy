using Newtonsoft.Json;

namespace ProcessingJSON.Models
{
    public class YouTubeVideo
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }
    }
}

