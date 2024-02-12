using CryptoScanner.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CryptoScanner.UI.Pages
{
    public class IndexModel : PageModel
    {
        public List<ExchangeRootModel>? _ExchangeInfo { get; set; } = new()
        {
            new ExchangeRootModel
            {
                Id = "1",
                Name = "WombatCoin",
                YearEstablished = 1992,
                Country = "Sweden",
                Description = "a currency for wombats implemented in 1992",
                Url = "TBA",
                Image = "TBA",
                HasTradingIncentive = true,
                TrustScore = 10,
                TrustScoreRank = 1,
                TradeVolume24hBtc = 5111,
                TradeVolume24hBtcNormalized = 911

            },
            new ExchangeRootModel
            {
                Id = "2",
                Name = "PokeCoin",
                YearEstablished = 1825,
                Country = "Denmark",
                Description = "a currency for pokemon implemented in 1825",
                Url = "TBA",
                Image = "TBA",
                HasTradingIncentive = false,
                TrustScore = 7,
                TrustScoreRank = 3,
                TradeVolume24hBtc = 8667,
                TradeVolume24hBtcNormalized = 112

            },
            new ExchangeRootModel
            {
                Id = "3",
                Name = "MuppetCoin",
                YearEstablished = 2011,
                Country = "Finland",
                Description = "a currency for muppets implemented in 2011",
                Url = "TBA",
                Image = "TBA",
                HasTradingIncentive = true,
                TrustScore = 2,
                TrustScoreRank = 4,
                TradeVolume24hBtc = 231,
                TradeVolume24hBtcNormalized = 191

            }
        };



        public void OnGet()
        {

        }
    }
}
