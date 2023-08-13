using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Member.Controllers;
[Area("Member")]
public class CommnetController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}