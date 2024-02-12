
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
        //public async Task<SingleRootModel> GetValueInSec(int sek)
        //{

        //    HttpResponseMessage response = await Client.GetAsync(sek);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        string cryptoJson = await response.Content.ReadAsStringAsync();
        //        SingleRootModel? singleModel = JsonConvert.DeserializeObject<SingleRootModel>(cryptoJson);

        //        return singleModel;

        //    }
        //    throw new HttpRequestException();
        //}
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


