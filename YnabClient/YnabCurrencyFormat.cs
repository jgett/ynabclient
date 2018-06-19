using Newtonsoft.Json;

namespace YnabClient
{
    public class YnabCurrencyFormat
    {
        [JsonProperty("iso_code")]
        public string IsoCode { get; set; }

        [JsonProperty("example_format")]
        public string ExampleFormat { get; set; }

        [JsonProperty("decimal_digits")]
        public int DecimalDigits { get; set; }

        [JsonProperty("decimal_separator")]
        public string DecimalSeparator { get; set; }

        [JsonProperty("symbol_first")]
        public bool SymbolFirst { get; set; }

        [JsonProperty("group_separator")]
        public string GroupSeparator { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("display_symbol")]
        public bool DisplaySymbol { get; set; }
    }
}