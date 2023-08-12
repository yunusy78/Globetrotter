using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Default;

public class Slider: ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}