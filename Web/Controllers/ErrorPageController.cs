using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class ErrorPageController : Controller
{
    // GET
    public IActionResult Index(int code)
    {
        return View();
    }
}