using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class UserController : Controller
{
    
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IReservationService _reservationService;
    
    public UserController(UserManager<ApplicationUser> userManager, IReservationService reservationService)
    {
        _userManager = userManager;
        _reservationService = reservationService;
    }
    
    // GET
    public IActionResult Index()
    {
        var users = _userManager.Users.ToList();
        return View(users);
    }
    
    public async Task<IActionResult> Delete(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user != null)
        {
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
        }
        return RedirectToAction("Index");
    }
    
    public async Task<IActionResult> FindReservation(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        ViewBag.UserName = user!.FirstName + " " + user.LastName;
        var reservations = _reservationService.GetListWithDestination(user!.Id);
        return View(reservations);
       
    }
    
    
    
  
    
}