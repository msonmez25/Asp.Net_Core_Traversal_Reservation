using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DocumentFormat.OpenXml.Spreadsheet;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/CommentArea")]
    public class CommentAreaController : Controller
    {
        CommenttManager commenttManager = new CommenttManager(new EfCommenttDal());

        private readonly UserManager<AppUser> _userManager;

        public CommentAreaController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }


        [Route("MyComment")]
        public async Task<IActionResult> MyComment(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            id= user.Id;
            var values = commenttManager.TGetListCommentWithUser(id);        

            return View(values);
        }



        [HttpGet]
        [Route("DetailCommentt/{id}")]
        public IActionResult DetailCommentt(int id )
        {
            var values = commenttManager.TGetByID(id);          
            return View(values);
        }

        [HttpPost]
        [Route("DetailCommentt/{id}")]
        public async Task<IActionResult> DetailCommentt(Commentt p,int id)
        {
            var userid = await _userManager.FindByNameAsync(User.Identity.Name);
            var rotaid = commenttManager.TGetListCommentWithDestination(id).FirstOrDefault();


            p.DestinationID = rotaid.DestinationID;
            p.AppUserID = userid.Id;
            p.CommentStatus = true;
            p.CommentDate = DateTime.Parse(DateTime.Now.ToString());
            commenttManager.TUpdate(p);
            return RedirectToAction("MyComment");
        }
    }
}
