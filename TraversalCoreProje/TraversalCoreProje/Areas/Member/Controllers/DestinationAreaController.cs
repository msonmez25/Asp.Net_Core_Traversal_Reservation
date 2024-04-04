using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{    
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class DestinationAreaController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var vaules = destinationManager.TGetList();
            return View(vaules);
        }


        public IActionResult GetCitiesSearchByName(string searchString)
        {
            ViewData["CurrenFilter"] = searchString;
            var values = from x in destinationManager.TGetList() select x;
            if(!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.City.Contains(searchString));
            }
            return View(values.ToList());
        }

    }
}
