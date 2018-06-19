using Newtonsoft.Json;

namespace YnabClient
{
    public class YnabResponse<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
