using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CommentAdminController : Controller
    {
        CommenttManager commenttManager = new CommenttManager(new EfCommenttDal());

        private readonly ICommenttService _commenttService;

        public CommentAdminController(ICommenttService commenttService)
        {
            _commenttService = commenttService;
        }

        public IActionResult Index()
        {
            var values = _commenttService.TGetListCommentWithUser();
            return View(values);
        }


        public IActionResult PasifCommentt(int id)
        {
            var values = _commenttService.TGetByID(id);
            values.CommentStatus = false;
            _commenttService.TUpdate(values);
            return RedirectToAction("CommentAdmin","Admin" );
        }

        public IActionResult AktifCommentt(int id)
        {
            var values = _commenttService.TGetByID(id);
            values.CommentStatus = true;
            _commenttService.TUpdate(values);
            return RedirectToAction("CommentAdmin", "Admin");
        }

        public IActionResult DetailCommentt(int id)
        {
            var values = _commenttService.TGetByID(id);
            var rota = commenttManager.TGetListCommentWithDestination(id).FirstOrDefault();
            ViewBag.rotaName = rota.Destination.Country + " - " +rota.Destination.City;
            return View(values);
        }

    }
}
