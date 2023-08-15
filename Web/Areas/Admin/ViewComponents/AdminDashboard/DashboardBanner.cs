using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.ViewComponent.AdminDashboard;

public class DashboardBanner: Microsoft.AspNetCore.Mvc.ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}