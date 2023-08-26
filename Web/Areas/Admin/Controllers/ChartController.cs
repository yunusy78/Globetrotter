using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers;

public class ChartController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}