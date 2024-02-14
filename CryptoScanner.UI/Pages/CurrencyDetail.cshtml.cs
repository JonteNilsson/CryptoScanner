using CryptoScanner.App.ApiCallers;
using CryptoScanner.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CryptoScanner.UI.Pages
{
    public class CurrencyDetailModel : PageModel
    {
        public string? ErrorMessage { get; set; }

        public ExchangeRootModel? Exchange { get; set; }
        public Root? Value { get; set; }


        public async Task OnGet(string exchangeName)
        {
            try
            {
                Exchange = await new CryptoApiCaller().MakeCall($"exchanges/{exchangeName.ToLower()}");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }

            try
            {
                Value = await new CryptoApiCaller().GetValueInSec("simple/price?ids=bitcoin&vs_currencies=sek");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
