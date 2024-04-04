using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Member.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class UserAdminController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;


        public UserAdminController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            return View(values);
        }


        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.TGetByID(id);
            _appUserService.TDelete(values);
            return RedirectToAction("Index", "UserAdmin", new { area = "Admin" });
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _appUserService.TGetByID(id);            
            return View(values);
        }


        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index", "UserAdmin", new { area = "Admin" });
        }


        public IActionResult CommentUser(int id)
        {
            _appUserService.TGetList();
            return View();
        }


        public IActionResult ReservationUser(int id)
        {            
            var values = _reservationService.TGetListWithReservationByUser(id);
            var user = _appUserService.TGetByID(id);
            ViewBag.Name = user.Name + " " + user.Surname;
            return View(values);
        }
    }
}
