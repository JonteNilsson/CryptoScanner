using Newtonsoft.Json;

namespace CryptoScanner.Data.Models
{
    public class SekModel
    {
        [JsonProperty("sek")]
        public decimal? Sek { get; set; }
    }

    public class Bitcoin
    {
        [JsonProperty("sek")]
        public int? Sek { get; set; }
    }

    public class Root
    {
        [JsonProperty("bitcoin")]
        public Bitcoin Bitcoin { get; set; }
    }
}
