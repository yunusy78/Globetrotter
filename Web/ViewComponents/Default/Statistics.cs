using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Default;

public class Statistics : ViewComponent
{
    private readonly Context _db;
    
    public Statistics(Context db)
    {
        _db = db;
    }
    
    public IViewComponentResult Invoke()
    {
        ViewBag.TotalDestination = _db.Destinations.Count();
        ViewBag.TotalGuide = _db.Guides.Count();
        //ViewBag.UserCount = _db.Users.Count();
        return View();
    }
    
    
    
}