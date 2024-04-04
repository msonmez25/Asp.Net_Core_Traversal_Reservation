using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        NewsletterManager newsletterManager = new NewsletterManager(new EfNewsletterDal());

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public PartialViewResult _AddNewsletterPartial()
        {
            return PartialView();

        }

        [HttpPost]
        public IActionResult _AddNewsletterPartial(Newsletter newsletter)
        {
            newsletterManager.TAdd(newsletter);
            return RedirectToAction("Index", "Default");

        }
    }
}
