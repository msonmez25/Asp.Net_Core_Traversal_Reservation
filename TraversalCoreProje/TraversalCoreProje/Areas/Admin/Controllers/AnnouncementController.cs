using AutoMapper;
using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DTOLayer.DTOs.Announcement;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;
using System;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;


        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<ViewAnnouncementDto>>(_announcementService.TGetList());
            return View(values);
        }


        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddAnnouncement(AddAnnouncementDto model)
        {
            if(ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement ()
                {
                    Content=model.Content,
                    Title = model.Title,
                    Status = true,
                    DateAnnouncement = Convert.ToDateTime(DateTime.Now.ToShortDateString())                    
                });
                return RedirectToAction("Announcement", "Admin");
            }
            return View(model);
        }

        public IActionResult PasifAnnouncement(int id, bool Status)
        {
            var values = _announcementService.TGetByID(id);
            values.Status = false;
            _announcementService.TUpdate(values);
            return RedirectToAction("Announcement", "Admin");
        }

        public IActionResult AktifAnnouncement(int id, bool Status)
        {
            var values = _announcementService.TGetByID(id);
            values.Status = true;
            _announcementService.TUpdate(values);
            return RedirectToAction("Announcement", "Admin");
        }


        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<UpdateAnnouncementDto>(_announcementService.TGetByID(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(UpdateAnnouncementDto model)
        {
            if(ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementID = model.AnnouncementID,
                    Title = model.Title,
                    Content = model.Content,
                    DateAnnouncement = model.DateAnnouncement,
                    Status=true
                });
                return RedirectToAction("Announcement", "Admin");
            }
            return View(model);
        }
    }
}
