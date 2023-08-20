using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.About;

public class AboutHome : ViewComponent
{
    
    private readonly IAboutService _aboutService;
    
    
    public AboutHome(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }
    
    
    public IViewComponentResult Invoke()
    {

        var about = _aboutService.GetAll();
        return View(about);
    }
    
}