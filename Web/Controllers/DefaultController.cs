using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}