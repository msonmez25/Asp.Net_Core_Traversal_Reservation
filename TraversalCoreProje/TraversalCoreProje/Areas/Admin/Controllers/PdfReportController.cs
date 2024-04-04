using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/pdfReports/" +"dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            Paragraph paragraph = new Paragraph("Traversal Rezervasyon PDF Raporu");
            document.Add(paragraph);
            document.Close();
            return File("/pdfReports/dosya1.pdf", "application/pdf","dosya1.pdf");
        }


        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfReports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfTable = new PdfPTable(3);
            pdfTable.AddCell("Misafir Adı");
            pdfTable.AddCell("Misafir Soyadı");
            pdfTable.AddCell("Misafir TC");

            pdfTable.AddCell("Ahmet Tuna");
            pdfTable.AddCell("Sönmez");
            pdfTable.AddCell("22222222220");

            pdfTable.AddCell("Melek");
            pdfTable.AddCell("Sönmez");
            pdfTable.AddCell("33333333330");

            pdfTable.AddCell("Mehmet Sait");
            pdfTable.AddCell("Sönmez");
            pdfTable.AddCell("11111111110");

            document.Add(pdfTable);
            document.Close();
            return File("/pdfReports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}
