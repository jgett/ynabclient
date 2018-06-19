using Newtonsoft.Json;

namespace YnabClient
{
    public class UserData
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
