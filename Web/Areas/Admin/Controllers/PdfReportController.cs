using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Document = Microsoft.CodeAnalysis.Document;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class PdfReportController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult ExportDestinationPdf()
    {
        // iTextSharp Document
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf" + "/DestinationPdf.pdf");

        using (var stream = new FileStream(path, FileMode.Create))
        {
            var document = new iTextSharp.text.Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();

            Paragraph paragraph = new Paragraph("Destination List");
            document.Add(paragraph);

            document.Close();
        }

        // Microsoft.CodeAnalysis.Document
        var sourceCodeDocument = "Travel Agency";

        return File("/pdf/DestinationPdf.pdf", "application/pdf", "DestinationPdf.pdf");
    }
    
    public IActionResult CustomerPdf()
    {
        // iTextSharp Document
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf" + "/CustomerPdf.pdf");

        using (var stream = new FileStream(path, FileMode.Create))
        {
            var document = new iTextSharp.text.Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            
            PdfPTable table = new PdfPTable(4);
            table.AddCell("Customer Name");
            table.AddCell("Customer Surname");
            table.AddCell("Customer Email");
            table.AddCell("Customer Password");
            table.AddCell("Yunus");
            table.AddCell("Yılmaz");
            table.AddCell("yunusy@gmail.com");
            table.AddCell("123456");
            table.AddCell("Yunus");
            table.AddCell("Yılmaz");
            table.AddCell("yunusy@gmail.com");
            table.AddCell("123456");
            table.AddCell("Yunus");
            table.AddCell("Yılmaz");
            table.AddCell("yunusy@gmail.com");
            table.AddCell("123456");
            document.Add(table);
            document.Close();
        }
        

        return File("/pdf/CustomerPdf.pdf", "application/pdf", "CustomerPdf.pdf");
    }

}