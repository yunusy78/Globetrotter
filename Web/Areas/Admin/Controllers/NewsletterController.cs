using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class NewsletterController : Controller
{
    private readonly INewsletterService _newsletterService;
    
    public NewsletterController(INewsletterService newsletterService)
    {
        _newsletterService = newsletterService;
    }
    
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult NewsletterList()
    {
        var model = _newsletterService.GetAll();
        return Json(model);
        
        
    }
    
    public IActionResult GetById(Guid id)
    {
       
        var model = _newsletterService.GetById(id);
        if (model!= null)
        {
            return Json(model);
        }
        return Json(new { error = "Writer not found" });

    }
    
    [HttpPost]
    
    public IActionResult Update(Newsletter model)
    {
        var abonenter = _newsletterService.GetById(model.Id);
        if (abonenter != null)
        {
            abonenter.Status = model.Status;
            abonenter.Email = model.Email;
            _newsletterService.Update(abonenter);
            return Json(abonenter);
        }
        return Json(new { error = "Abonenter not found" });
    }
    
    [HttpPost]
    public IActionResult Delete(Guid id)
    {
        var abonenter = _newsletterService.GetById(id);
        if (abonenter != null)
        {
            _newsletterService.Delete(abonenter);
            return Json(abonenter);
        }
        return Json(new { error = "Abonenter not found" });
    }
    
    
    [HttpPost]
    public IActionResult Add(Newsletter model)
    {
         model.Status = true;
            _newsletterService.Add(model);
            return RedirectToAction("Index", "Default" ,new{Area=""});

    }
    
    
   
}