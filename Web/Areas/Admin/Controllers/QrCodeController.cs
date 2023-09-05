using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers;

public class QRcodeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}