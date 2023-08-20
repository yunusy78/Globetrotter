using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class GuideController : Controller
{ 
    private readonly IGuideService _guideService;
    
    public GuideController(IGuideService guideService)
    {
        _guideService = guideService;
    }
    
    
    // GET
    public IActionResult Index()
    {
        var guide = _guideService.GetListWithDestination();
        return View(guide);
    }
}