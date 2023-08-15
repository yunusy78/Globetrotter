using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Member.Controllers;

[Area("Member")]
public class DashboardController : Controller
{
    
    private readonly UserManager<ApplicationUser> _um;
    
    public DashboardController(UserManager<ApplicationUser> um)
    {
        _um = um;
    }
    
    
    // GET
    public IActionResult Index()
    {
        
        var user =  _um.GetUserAsync(User).Result;
        ViewBag.Name = user.FirstName + " " + user.LastName;
        ViewBag.Image = user.ImageUrl;
        
        return View();
    }
}