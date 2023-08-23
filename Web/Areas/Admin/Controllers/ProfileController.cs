using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.Member.Models;

namespace Web.Areas.Member.Controllers;
[Area("Member")]
[Authorize]
public class ProfileController : Controller
{
    private readonly UserManager<ApplicationUser> _um;
    
    public ProfileController(UserManager<ApplicationUser> um)
    {
        _um = um;
    }
    
    
    
    public IActionResult UpdateProfile()
    {
        var user =  _um.GetUserAsync(User).Result;
        UserUpdateProfileViewModel model = new UserUpdateProfileViewModel();
        model.FirstName = user.FirstName;
        model.LastName = user.LastName;
        model.Email = user.Email;
        model.PhoneNumber = user.PhoneNumber;
        model.About= user.About;
        return View(model);
    }
    
    
    [HttpPost]
    
    public IActionResult UpdateProfile(UserUpdateProfileViewModel model, IFormFile? file)
    {
        var user =  _um.GetUserAsync(User).Result;
        user.FirstName = model.FirstName;
        user.LastName = model.LastName;
        user.Email = model.Email;
        user.PhoneNumber = model.PhoneNumber;
        user.Gender = model.Gender;
        user.About = model.About;
        user.PasswordHash = _um.PasswordHasher.HashPassword(user, model.Password);
        
        if (file != null)
        {
            var extension = Path.GetExtension(file.FileName);
            var newImageName = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImageFile/Profile/" + newImageName);
            var stream = new FileStream(location, FileMode.Create);
            file.CopyToAsync(stream);
            user.ImageUrl =@"/ImageFile/Profile/"+ newImageName;
        }
        else
        {
            user.ImageUrl = user.ImageUrl;
        }
        
        var result = _um.UpdateAsync(user).Result;
        
        if (result.Succeeded)
        {
            TempData["Message"] = "Oppdateringen var vellykket.";
            return RedirectToAction("Index", "Dashboard", new{area="Member"});
        }
        else
        {
            TempData["Message"] = "Oppdateringen mislyktes.";
            return View();
        }

    }
    
    
    public IActionResult Index()
    {
        return View();
    }
    
    
    
    
}