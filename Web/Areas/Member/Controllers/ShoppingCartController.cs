using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Member.Controllers;

public class ShoppingCartController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}