using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class DestinationAdminController : Controller
    {
       

        private readonly IDestinationService _destinationService;
        private readonly IGuideService _guideService;

        public DestinationAdminController(IDestinationService destinationService, IGuideService guideService)
        {
            _destinationService = destinationService;
            _guideService = guideService;
        }

        
        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            List<SelectListItem> guides = (from x in _guideService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name + "  -  " + x.Description,
                                               Value = x.GuideID.ToString()
                                           }).ToList();
            ViewBag.v = guides;
            return View();
        }


        [HttpPost]
        public IActionResult AddDestination(Destination p)
        {
            _destinationService.TAdd(p);
            p.Date = DateTime.Parse(DateTime.Now.ToString());
            return RedirectToAction("Index", "DestinationAdmin", new { area = "Admin" });
        }

        
        public IActionResult DeleteDestination(int id, bool status)
        {
            var values = _destinationService.TGetByID(id);
            values.Status = false;
            _destinationService.TUpdate(values);
            return RedirectToAction("Index", "DestinationAdmin", new { area = "Admin" });
        }


        
        public IActionResult ActiveDestination(int id, bool status)
        {
            var values = _destinationService.TGetByID(id);
            values.Status = true;
            _destinationService.TUpdate(values);
            return RedirectToAction("Index", "DestinationAdmin", new { area = "Admin" });
        }


        public IActionResult DeleteRota(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return RedirectToAction("Index", "DestinationAdmin", new { area = "Admin" });
        }


        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            List<SelectListItem> guides = (from x in _guideService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name + "  -  " + x.Description,
                                               Value = x.GuideID.ToString()
                                           }).ToList();
            ViewBag.v = guides;


            var values = _destinationService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination p)
        {
            p.Status = true;
            p.Date = DateTime.Parse(DateTime.Now.ToString());
            _destinationService.TUpdate(p);
            return RedirectToAction("Index", "DestinationAdmin", new { area = "Admin" });
        }
    }
}
