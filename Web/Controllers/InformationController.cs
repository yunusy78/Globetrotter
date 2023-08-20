using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Member.Controllers;
[Area("Member")]
public class InformationController : Controller
{
    
    
    // GET
    public IActionResult Index()
    {
        return View();
    }
}