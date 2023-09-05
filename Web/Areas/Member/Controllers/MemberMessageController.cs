using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Member.Controllers;
[Area("Member")]
[Authorize ]
public class MessageController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}