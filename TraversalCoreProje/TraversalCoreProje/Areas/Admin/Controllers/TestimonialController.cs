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
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IActionResult Index()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }



        [HttpGet]
        public IActionResult DetailTestimonial(int id)
        {
            var values = testimonialManager.TGetByID(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult DetailTestimonial(Testimonial p)
        {
            testimonialManager.TUpdate(p);
            return RedirectToAction("Index", "Testimonial", new { area = "Admin" });
        }


        public IActionResult DeleteTestimonial(int id)
        {
            var values = testimonialManager.TGetByID(id);
            testimonialManager.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View(); 
        }


        [HttpPost]
        public IActionResult AddTestimonial(Testimonial p)
        {
            testimonialManager.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
