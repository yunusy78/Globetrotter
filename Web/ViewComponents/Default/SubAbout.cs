using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Default;

public class SubAbout : ViewComponent
{
    
    private readonly ISubAboutService _subAboutManager;
    
    
    public SubAbout(ISubAboutService subAboutManager)
    {
        _subAboutManager = subAboutManager;
    }
    
    public IViewComponentResult Invoke()
    {
        var result = _subAboutManager.GetAll();
        return View(result);
    }
    
}