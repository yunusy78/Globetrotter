using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.ViewComponents.AdminDashboard;

public class TotalRevenue : Microsoft.AspNetCore.Mvc.ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}