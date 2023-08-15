using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Member.ViewComponents.Dashboard;

public class GuideList : ViewComponent
{
    private readonly IGuideService _guideManager;
    
    public GuideList(IGuideService guideManager)
    {
        _guideManager = guideManager;
    }
    
    public IViewComponentResult Invoke()
    {
        var guides = _guideManager.GetAll();
        return View(guides);
    }
    
    
}