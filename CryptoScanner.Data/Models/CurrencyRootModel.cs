using Newtonsoft.Json;

namespace CryptoScanner.Data.Models
{
	public class CurrencyRootModel
	{
		[JsonProperty("id")]
		public string? Id { get; set; }

		[JsonProperty("symbol")]
		public string? Symbol { get; set; }

		[JsonProperty("name")]
		public string? Name { get; set; }
	}

	public class SingleRootModel
	{
		[JsonProperty("sek")]
		public int? Sek { get; set; }
	}

}
