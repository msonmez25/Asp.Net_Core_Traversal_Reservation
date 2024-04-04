using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        AppUserManager appUserManager = new AppUserManager(new EfAppUserDal());

        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        

        public IActionResult Index()
        {
            var values = _reservationService.TGetUserReservation();
            return View(values);
        }


        public IActionResult ChangeApprovedStatus(int id) 
        {
            var values = _reservationService.TGetByID(id);
            _reservationService.TReservationStatusChangeApproved(values.ReservationID);
            return RedirectToAction("Index");            
        }

        public IActionResult ChangeCanceledStatus(int id)
        {
            var values = _reservationService.TGetByID(id);
            _reservationService.TReservationStatusChangeCanceled(values.ReservationID);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteReservation(int id)
        {
            var values = _reservationService.TGetByID(id);
            _reservationService.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DetailReservation(int id)
        {
            List<SelectListItem> valuesRota = (from x in destinationManager.TActiveRoteList()
                                           select new SelectListItem
                                           {
                                               Text = x.Country + " - " + x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.v = valuesRota;


            List<SelectListItem> valuesUser = (from x in appUserManager.TGetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name + " " + x.Surname,
                                                   Value = x.Id.ToString()
                                               }).ToList();
            ViewBag.v2 = valuesUser;


            var values = _reservationService.TGetByID(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult DetailReservation(Reservation p)
        {
            _reservationService.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
