using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TraversalCoreProje.Areas.Admin.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?room_number=1&adults_number=2&checkout_date=2024-05-20&filter_by_currency=AED&units=metric&locale=en-gb&checkin_date=2024-05-19&dest_type=city&dest_id=-1456928&order_by=popularity&children_ages=5%2C0&children_number=2&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0"),
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
                var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(body);
                return View(values.results.ToList());
            }

        }



        [HttpGet]
        public IActionResult GetCityDestinationID()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> GetCityDestinationID(string cityID)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name=locale=en-gb&{cityID}"),
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
                return View();
            }

        }
    }
}
