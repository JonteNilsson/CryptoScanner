using Newtonsoft.Json;

namespace CryptoScanner.Data.Models
{
    public class NyModel
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("current_price")]
        public double? CurrentPrice { get; set; }

        [JsonProperty("market_cap")]
        public object MarketCap { get; set; }


    }
}
