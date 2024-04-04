using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.AdminDasboard
{
    public class _Cards1Statistic : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            //Tur Sayısı
            ViewBag.v1 = c.Destinations.Count();
            //Misafir Sayısı
            ViewBag.v2 = c.Users.Count();
            return View();
        }
    }
}
