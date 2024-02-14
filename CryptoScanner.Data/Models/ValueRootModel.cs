using Newtonsoft.Json;

namespace CryptoScanner.Data.Models
{
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
