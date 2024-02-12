using CryptoScanner.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CryptoScanner.UI.Pages
{
    public class CurrencyDetailModel : PageModel
    {

        public ExchangeRootModel? Exchange { get; set; }


        public void OnGet(ExchangeRootModel currencyInfo)
        {

        }
    }
}
