using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Member.ViewComponents.Dashboard;

public class PlatformSettings : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}