using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Default;

public class Statistics : ViewComponent
{
   
    
    public IViewComponentResult Invoke()
    {
        using var _db = new Context();
        ViewBag.TotalDestination = _db.Destinations.Count();
        ViewBag.TotalGuide = _db.Guides.Count();
        //ViewBag.UserCount = _db.Users.Count();
        return View();
    }
    
    
    
}