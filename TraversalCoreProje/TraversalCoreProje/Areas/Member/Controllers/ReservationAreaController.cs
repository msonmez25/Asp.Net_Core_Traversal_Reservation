using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]/{id?}")]
    public class ReservationAreaController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());

        private readonly UserManager<AppUser> _userManager;

        public ReservationAreaController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyActiveReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.TGetListWithReservationByAccepted(values.Id);
            return View(valuesList);
        }


        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.TGetListWithReservationByLast(values.Id);
            return View(valuesList);
        }


        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList= reservationManager.TGetListWithReservationByWaitAprroval(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TActiveRoteList()
                                           select new SelectListItem
                                           {
                                               Text=x.Country +" " +x.City,
                                               Value=x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation p)
        {         
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            p.AppUserId = user.Id;
            p.Status = "ONAY BEKLİYOR";
            reservationManager.TAdd(p);
            return RedirectToAction("MyApprovalReservation", "ReservationArea", new { area = "Member" });
        }


        public IActionResult Deneme()
        {
            return View();
        }
    }
}
