using Business.Abstract;
using Business.ValidationRules;
using Entity.Concrete;
using FluentValidation.Results;
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
    
     public IActionResult Add()
    {
        return View();
    }
    
    
    [HttpPost]
    public  IActionResult Add(Guide model, IFormFile? file1)
    {
        GuideValidator validator = new GuideValidator();
        ValidationResult result = validator.Validate(model);
        if (result.IsValid)
        {

            if (file1 != null)
            {
                var extension = Path.GetExtension(file1.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImageFile/Guide/" + newImageName);
                var stream = new FileStream(location, FileMode.Create);
                file1.CopyToAsync(stream);
                model.ImageUrl = @"/ImageFile/Guide/" + newImageName;
            }
            else
            {
                model.ImageUrl = "default.png ";
            }

            model.Status = true;
            _guideService.Add(model);
            return RedirectToAction("Index");
        }
        else
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
        }
        
        return View();

    }
    
    public IActionResult Update(Guid id)
    {
        var model = _guideService.GetById(id);
        return View(model);
    }


    [HttpPost]
    public IActionResult Update(Guide model, IFormFile file1)
    {
        GuideValidator validator = new GuideValidator();
        ValidationResult result = validator.Validate(model);
        if (result.IsValid)
        {
            if (file1 != null)
            {
                var extension = Path.GetExtension(file1.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImageFile/Guide/" + newImageName);
                var stream = new FileStream(location, FileMode.Create);
                file1.CopyToAsync(stream);
                model.ImageUrl = @"/ImageFile/Guide/" + newImageName;
            }
            else
            {
                model.ImageUrl = model.ImageUrl;
            }

            model.Status = model.Status;
            _guideService.Update(model);
            return RedirectToAction("Index");

        }
        else
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
        }

        return View();
    }
    
    

}