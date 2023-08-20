using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Guide;

public class GuideDetails : ViewComponent
{
    private readonly IGuideService _guideService;
    
    public GuideDetails(IGuideService guideService)
    {
        _guideService = guideService;
    }
    
    public IViewComponentResult Invoke(Guid id)
    {
        var model = _guideService.GetListByDestinationId(id);
        return View(model);
    }
    
    
    
}