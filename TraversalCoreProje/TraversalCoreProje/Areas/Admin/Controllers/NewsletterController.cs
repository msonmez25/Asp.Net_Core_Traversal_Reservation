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
    public class NewsletterController : Controller
    {

        NewsletterManager newsletterManager = new NewsletterManager(new EfNewsletterDal());

        public IActionResult Index()
        {
            var values = newsletterManager.TGetList();
            return View(values);
        }



        [HttpGet]
        public IActionResult DetailNewsletter(int id)
        {
            var values = newsletterManager.TGetByID(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult DetailNewsletter(Newsletter p)
        {
            newsletterManager.TUpdate(p);
            return RedirectToAction("Index", "Newsletter", new { area = "Admin" });
        }


        public IActionResult DeleteNewsletter(int id)
        {
            var values = newsletterManager.TGetByID(id);
            newsletterManager.TDelete(values);
            return RedirectToAction("Index");
        }


        //[HttpGet]
        //public IActionResult AddNewsletter()
        //{
        //    return View();
        //}


        //[HttpPost]
        //public IActionResult AddNewsletter(Newsletter p)
        //{
        //    newsletterManager.TAdd(p);
        //    return RedirectToAction("Index");
        //}
    }


}

