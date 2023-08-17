using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class ExelController : Controller
{
    private readonly IDestinationService _destinationService;
    
    private readonly IGuideService _guideService;
    
    private readonly IExelService _exelService;
    
    public ExelController(IDestinationService destinationService, IGuideService guideService, IExelService exelService)
    {
        _destinationService = destinationService;
        _guideService = guideService;
        _exelService = exelService;
    }
    public IActionResult Index()
    {
        return View();
    }
    
    // GET
    public IActionResult RapportDestination()
    {
        ExcelPackage excelPackage = new ExcelPackage();
        var ws = excelPackage.Workbook.Worksheets.Add("Side1");
        ws.Cells[1,1].Value = "Reisemål";
        ws.Cells[1,2].Value = "Beskrivelse";
        ws.Cells[1,3].Value = "Pris";
        ws.Cells[1,4].Value = "Antall Personer";
        ws.Cells[1,5].Value = "Dager";
        
        int rowCount = 2;
        
        foreach (var destination in _destinationService.GetAll())
        {
            ws.Cells[rowCount,1].Value = destination.City;
            ws.Cells[rowCount,2].Value = destination.Description;
            ws.Cells[rowCount,3].Value = destination.Price;
            ws.Cells[rowCount,4].Value = destination.Capacity;
            ws.Cells[rowCount,5].Value = destination.DayNight;
            rowCount++;
        }
        
        var bytes = excelPackage.GetAsByteArray();
        return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "destinasjonsliste.xlsx");
    }


    public IActionResult ExportStaticCsv()
    {
        ExcelPackage excelPackage = new ExcelPackage();
        var ws = excelPackage.Workbook.Worksheets.Add("Side1");

        ws.Cells[1, 1].Value = "Navn";
        ws.Cells[1, 2].Value = "E-post";
        ws.Cells[1, 3].Value = "Telefon";
        ws.Cells[1, 4].Value = "Beskrivelse";

        int rowCount = 2;

        foreach (var guide in _guideService.GetAll())
        {
            ws.Cells[rowCount, 1].Value = guide.FullName;
            ws.Cells[rowCount, 2].Value = guide.Email;
            ws.Cells[rowCount, 3].Value = guide.FacebookUrl;
            ws.Cells[rowCount, 4].Value = guide.Description;
            rowCount++;
        }
        
        var bytes = excelPackage.GetAsByteArray();
        return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "guideliste.xlsx");
    }

    public IActionResult ManagerReport()
    {
        return File (_exelService.ExportStaticExcel(_guideService.GetAll()), 
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "guideliste.xlsx");
        
    }
    

}