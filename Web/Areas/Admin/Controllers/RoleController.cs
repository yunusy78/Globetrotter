using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers;

public class RoleController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}