using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class ReservationController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}