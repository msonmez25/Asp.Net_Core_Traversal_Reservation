using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using TraversalCoreProje.Models;
using System.IO;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ExcelReportController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelReportController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }




        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    Country = x.Country,
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity

                }).ToList();
            }
            return destinationModels;
        }

        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocuments.spreadsheetml.sheet","YeniExcel.xlsx");
            //application/vnd.openxmlformats-officedocuments.spreadsheetml.sheet
            
        }

        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Ülke";
                workSheet.Cell(1, 2).Value = "Şehir";
                workSheet.Cell(1, 3).Value = "Konaklama Süresi";
                workSheet.Cell(1, 4).Value = "Fiyat";
                workSheet.Cell(1, 5).Value = "Kapasite";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.Country;
                    workSheet.Cell(rowCount, 2).Value = item.City;
                    workSheet.Cell(rowCount, 3).Value = item.DayNight;
                    workSheet.Cell(rowCount, 4).Value = item.Price;
                    workSheet.Cell(rowCount, 5).Value = item.Capacity;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocuments.spreadsheetml.sheet", "YeniListe.xlsx");
                }
            }
        }
    }
}
