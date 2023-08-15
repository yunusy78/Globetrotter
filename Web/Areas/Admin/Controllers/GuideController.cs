using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers;

[Area("Admin")]
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
        var model = _guideService.GetAll();
        return View(model);
    }

    public IActionResult Active(Guid id)
    {
        var guide = _guideService.GetById(id);
        guide.Status = true;
        _guideService.Update(guide);
        return RedirectToAction("Index");
    }

    public IActionResult Passive(Guid id)
    {
        var guide = _guideService.GetById(id);
        guide.Status = false;
        _guideService.Update(guide);
        return RedirectToAction("Index");
    }
    
    public IActionResult Delete(Guid id)
    {
        var guide = _guideService.GetById(id);
        _guideService.Delete(guide);
        return RedirectToAction("Index");
    }
}