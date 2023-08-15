using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.ViewComponents.AdminDashboard;

public class CartStatistic : Microsoft.AspNetCore.Mvc.ViewComponent
{ 
    
    
    public IViewComponentResult Invoke()
    {
        using var _context = new Context();
        ViewBag.TotaltRoter = _context.Destinations.Count();
        ViewBag.TotaltClient = _context.Users.Count();
        return View();
    }
    
}