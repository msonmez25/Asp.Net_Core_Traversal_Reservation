using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using TraversalCoreProje.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //List<ExchangeViewModel> exchangeViewModels = new List<ExchangeViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "a0e5b25e3bmsh94b0f760d1818e4p1643b8jsnb755f2c481a0" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();                
                var values = JsonConvert.DeserializeObject<ExchangeViewModel>(body);                
                return View(values.exchange_rates.ToList());
            }
        }
    }
}

