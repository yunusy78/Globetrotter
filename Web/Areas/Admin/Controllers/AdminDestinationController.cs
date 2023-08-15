using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Web.Areas.Admin.Controllers;
[Area( "Admin")]
public class AdminDestinationController : Controller
{
    private readonly IDestinationService _destinationManager;
    
    
    public AdminDestinationController(IDestinationService destinationManager)
    {
        _destinationManager = destinationManager;
    }
    
    
    public IActionResult Index()
    {
        var result = _destinationManager.GetAll();
        return View(result);
    }
    
    public IActionResult Add()
    {
        return View();
    }
    
    
    [HttpPost]
    public  IActionResult Add(Destination model, IFormFile? file1, IFormFile? file2, IFormFile? file3)
    {
        
            if (file1 != null)
            {
                var extension = Path.GetExtension(file1.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImageFile/Destination/" + newImageName);
                var stream = new FileStream(location, FileMode.Create);
                file1.CopyToAsync(stream);
                model.ImageUrl =@"/ImageFile/Destination/"+ newImageName;
            }
            else
            {
                model.ImageUrl = "default.png ";
            }
            
            if (file2 != null)
            {
                var extension = Path.GetExtension(file2.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImageFile/Destination/" + newImageName);
                var stream = new FileStream(location, FileMode.Create);
                file2.CopyToAsync(stream);
                model.ImageUrl2 =@"/ImageFile/Destination/"+ newImageName;
            }
            else
            {
                model.ImageUrl2 = "default.png ";
            }
            
            
            if (file3 != null)
            {
                var extension = Path.GetExtension(file3.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImageFile/Destination/" + newImageName);
                var stream = new FileStream(location, FileMode.Create);
                file3.CopyToAsync(stream);
                model.CoverImageUrl =@"/ImageFile/Destination/"+ newImageName;
            }
            else
            {
                model.CoverImageUrl = "default.png ";
            }
            
            
             model.Status = true;
            _destinationManager.Add(model);
            return RedirectToAction("Index");
        
    }
    
    
    
    
    
    
    public IActionResult Edit(Guid id)
    {
        var result = _destinationManager.GetById(id);
        return View(result);
    }
    
     [HttpPost]
    public async Task<IActionResult> Edit(Destination destination, IFormFile? file1, IFormFile? file2, IFormFile? file3)
    {
        
            if (file1 != null)
            {
                var extension = Path.GetExtension(file1.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImageFile/Destination/" + newImageName);
                var stream = new FileStream(location, FileMode.Create);
                file1.CopyToAsync(stream);
                destination.ImageUrl =@"/ImageFile/Destination/"+ newImageName;
            }
            else
            {
                destination.ImageUrl = destination.ImageUrl;
            }
            
            if (file2 != null)
            {
                var extension = Path.GetExtension(file2.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImageFile/Destination/" + newImageName);
                var stream = new FileStream(location, FileMode.Create);
                file2.CopyToAsync(stream);
                destination.ImageUrl2 =@"/ImageFile/Destination/"+ newImageName;
            }
            else
            {
                destination.ImageUrl2 = destination.ImageUrl2;
            }
            
            
            if (file3 != null)
            {
                var extension = Path.GetExtension(file3.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImageFile/Destination/" + newImageName);
                var stream = new FileStream(location, FileMode.Create);
                file3.CopyToAsync(stream);
                destination.CoverImageUrl =@"/ImageFile/Destination/"+ newImageName;
            }
            else
            {
                destination.CoverImageUrl = destination.CoverImageUrl;
            }
        
            _destinationManager.Update(destination);
            return RedirectToAction("Index");
        
    }
    
    
    public IActionResult Delete(Guid id)
    {
        var result = _destinationManager.GetById(id);
        _destinationManager.Delete(result);
        return RedirectToAction("Index");
    }
    
    
}