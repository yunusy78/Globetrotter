using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.ViewComponents.AdminDashboard;

public class GuidesList : Microsoft.AspNetCore.Mvc.ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}