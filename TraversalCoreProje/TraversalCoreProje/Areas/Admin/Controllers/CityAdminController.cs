using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CityAdminController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityAdminController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        // Rota Listelemek
        public IActionResult RotaList()
        {
            var jsonRota = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonRota);
        }


        //Rota Eklemek
        [HttpPost]
        public IActionResult AddRota(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        //Rota Silmek
        public IActionResult DeleteRota(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return NoContent();
        }


        // Id ye göre getirmek
        public IActionResult GetRotaByID(int DestinationID)
        {
            var values = _destinationService.TGetByID(DestinationID);
            if (values == null)
            {

            }
            else
            {
                var jsonValues = JsonConvert.SerializeObject(values);
                return Json(jsonValues);
            }
            return View();
        }


        //Rota Güncellemek
        [HttpPost]
        public IActionResult UpdateRota(Destination destination)
        {            
            _destinationService.TUpdate(destination);
            var v=JsonConvert.SerializeObject(destination);
            return Json(v);
        }



        //public static List<CityClass> cities = new List<CityClass>
        //{
        //    new CityClass
        //    {
        //        CityID=1,
        //        CityName="Üsküp",
        //        CityCountry="Makedonya"
        //    },
        //    new CityClass
        //    {
        //        CityID=2,
        //        CityName="Roma",
        //        CityCountry="İtalya"
        //    },
        //    new CityClass
        //    {
        //        CityID=3,
        //        CityName="Paris",
        //        CityCountry="Fransa"
        //    }
        //};


    }
}
