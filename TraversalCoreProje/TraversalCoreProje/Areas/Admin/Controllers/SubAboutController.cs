using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class SubAboutController : Controller
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());


        public IActionResult Index()
        {
            var values = subAboutManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DetailSubAbout(int id)
        {
            var values = subAboutManager.TGetByID(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult DetailSubAbout(SubAbout p)
        {
            subAboutManager.TUpdate(p);
            return RedirectToAction("Index", "SubAbout", new { area = "Admin" });
        }
    }
}
