using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{    
    public class CommenttController : Controller
    {
        CommenttManager commenttManager = new CommenttManager(new EfCommenttDal());

        

        [HttpGet]
        public PartialViewResult AddCommentt()
        {            
            return PartialView();
        }


        [HttpPost]
        public IActionResult AddCommentt(Commentt p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToString());
            p.CommentStatus = true;
            commenttManager.TAdd(p);
            return RedirectToAction("Index","Destination");
        }

    }
}
