using Newtonsoft.Json;

namespace ProcessingJSON.Models
{
    public class Link
    {        
        [JsonProperty("@href")]
        public string Url { get; set; }
    }
}
