using Newtonsoft.Json;

namespace YnabClient
{
    public class YnabDateFormat
    {
        [JsonProperty("format")]
        public string Format { get; set; }
    }
}