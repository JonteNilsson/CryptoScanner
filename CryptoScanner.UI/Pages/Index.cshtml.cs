using CryptoScanner.App.ApiCallers;
using CryptoScanner.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CryptoScanner.UI.Pages
{
	public class IndexModel : PageModel
	{
		public List<ExchangeRootModel>? _Exchanges { get; set; }

		public string? ErrorMessage { get; set; }

		public int RandomNumber { get; set; } = new Random().Next(1, 11);

		public async Task OnGet()
		{
			try
			{
				_Exchanges = await new CryptoApiCaller().MakeCallForTen($"exchanges?per_page=10&page={RandomNumber}");
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
		}
	}
}
