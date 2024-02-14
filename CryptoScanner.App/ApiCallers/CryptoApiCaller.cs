
using CryptoScanner.Data.Models;
using Newtonsoft.Json;

namespace CryptoScanner.App.ApiCallers
{
	public class CryptoApiCaller
	{

		public HttpClient Client { get; set; }
		public CryptoApiCaller()
		{
			Client = new();

			Client.BaseAddress = new Uri("https://api.coingecko.com/api/v3/");
		}

		//public async Task<CurrencyRootModel> GetCurrencyName(string cryptoName)
		//{
		//    HttpResponseMessage response = await Client.GetAsync(cryptoName.ToLower());

		//    if (response.IsSuccessStatusCode)
		//    {
		//        string cryptoJson = await response.Content.ReadAsStringAsync();
		//        CurrencyRootModel? cryptoModel = JsonConvert.DeserializeObject<CurrencyRootModel>(cryptoJson);

		//        return cryptoModel;

		//    }
		//    throw new HttpRequestException();
		//}
		public async Task<SekModel> GetValueInSec(string url)
		{

			HttpResponseMessage response = await Client.GetAsync(url);

			if (response.IsSuccessStatusCode)
			{
				string cryptoJson = await response.Content.ReadAsStringAsync();


				// Dynamic parsing
				var data = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(cryptoJson);  // En dictionary där "key" är namnet på valutan, och den tar emot dynamic(vad som helst)

				foreach (var item in data)
				{
					SekModel currency = JsonConvert.DeserializeObject<SekModel>(item.Value.ToString());
					return currency;
				}


				var singleModel = JsonConvert.DeserializeObject<SekModel>(cryptoJson);

				/* return singleModel;*/ // TODO: CHange to sek model

			}
			throw new HttpRequestException();
		}
		public async Task<ExchangeRootModel> MakeCall(string exchangeName)
		{
			HttpResponseMessage response = await Client.GetAsync(exchangeName.ToLower());

			if (response.IsSuccessStatusCode)
			{
				string cryptoJson = await response.Content.ReadAsStringAsync();
				ExchangeRootModel? exchangeModel = JsonConvert.DeserializeObject<ExchangeRootModel>(cryptoJson);

				return exchangeModel!;

			}
			throw new HttpRequestException();
		}


		public async Task<List<ExchangeRootModel>> MakeCallForTen(string url)
		{
			HttpResponseMessage response = await Client.GetAsync(url.ToLower());

			if (response.IsSuccessStatusCode)
			{
				string cryptoJson = await response.Content.ReadAsStringAsync();
				List<ExchangeRootModel>? exchangeModels = JsonConvert.DeserializeObject<List<ExchangeRootModel>>(cryptoJson);

				return exchangeModels!;

			}
			throw new HttpRequestException();
		}


	}
}


