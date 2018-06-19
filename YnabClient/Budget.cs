using Newtonsoft.Json;
using System;

namespace YnabClient
{
    public class Budget
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_modified_on")]
        public DateTime LastModifiedOn { get; set; }

        [JsonProperty("date_format")]
        public YnabDateFormat DateFormat { get; set; }

        [JsonProperty("currency_format")]
        public YnabCurrencyFormat CurrencyFormat { get; set; }

        [JsonProperty("first_month")]
        public DateTime FirstMonth { get; set; }

        [JsonProperty("last_month")]
        public DateTime LastMonth { get; set; }
    }
}
