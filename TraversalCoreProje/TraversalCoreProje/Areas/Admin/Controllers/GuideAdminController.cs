using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class GuideAdminController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideAdminController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }


        
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddGuide(Guide p)
        {
            GuideAdminValidator validationRules = new GuideAdminValidator();
            ValidationResult result = validationRules.Validate(p);

            if(result.IsValid)
            {
                _guideService.TAdd(p);
                return RedirectToAction("Index","GuideAdmin",new { area = "Admin" });
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            
        }



        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditGuide(Guide p)
        {
            p.Status = true;
            _guideService.TUpdate(p);
            return RedirectToAction("Index", "GuideAdmin", new { area = "Admin" });
        }


        public IActionResult PasifGuide(int id, bool Status)
        {
            _guideService.TChangeToFalseByGuide(id);
            //var values = _guideService.TGetByID(id);
            //values.Status = false;
            //_guideService.TUpdate(values);
            return RedirectToAction("Index", "GuideAdmin", new { area = "Admin" });
        }

        public IActionResult AktifGuide(int id, bool Status)
        {
            _guideService.TChangeToTrueByGuide(id);
            //var values = _guideService.TGetByID(id);
            //values.Status = true;
            //_guideService.TUpdate(values);
            return RedirectToAction("Index", "GuideAdmin", new { area = "Admin" });
        }

    }
}
