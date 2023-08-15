using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using DataAccess.Repository;
using Entity.Concrete;
using Entity.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.Member.Controllers;

[Area("Member")]
[Authorize]
public class ReservationController : Controller
{
    private readonly Context _db;
    private readonly UserManager<ApplicationUser> _um;
    private readonly IDestinationService _destinationManager;
    private readonly IReservationService _reservationManager;
    
    public ReservationController(UserManager<ApplicationUser> um, IDestinationService destinationManager , IReservationService reservationManager)
    {
        _um = um;
           _destinationManager = destinationManager;
        _reservationManager = reservationManager;
       
    }
    
    
    // GET
    public IActionResult Index()
    {
        var user =  _um.GetUserAsync(User).Result;
        var result = _reservationManager.GetListWithDestination(user!.Id);
        return View(result);
    }

    public IActionResult AddReservation()
    {
        List<SelectListItem> result = (from x in _destinationManager.GetAll()
            select new SelectListItem
            {
                Text = x.City,
                Value = x.Id.ToString()
            }).ToList();
      ViewBag.Destination = result;
        return View();
    }

    [HttpPost]
    public IActionResult AddReservation(Reservation model)
    {
        var user =  _um.GetUserAsync(User).Result;
        var destination = _destinationManager.GetById(model.DestinationId);
        model.UserId = user.Id;
        model.ReservationDate = DateTime.Now;
        model.Status = StatusService.Pending;
        model.TotalPrice = model.PersonCount * destination.Price;
        _reservationManager.Add(model);
        return RedirectToAction("Index","Reservation", new{area="Member"});
    }
    
    public IActionResult DeleteReservation(Guid id)
    {
        var result = _reservationManager.GetById(id);
        _reservationManager.Delete(result);
        return RedirectToAction("Index","Reservation", new{area="Member"});
    }
    
    public IActionResult UpdateReservation(Guid id)
    {
        var result = _reservationManager.GetById(id);
        return View(result);
    }
    
    [HttpPost]
    public IActionResult UpdateReservation(Reservation model)
    {
        var result = _reservationManager.GetById(model.Id);
        result.PersonCount = model.PersonCount;
        result.TotalPrice = model.TotalPrice;
        _reservationManager.Update(result);
        return RedirectToAction("Index","Reservation", new{area="Member"});
    }
    
    public IActionResult ReservationSuccess()
    {
        
        return View();
    }
    
    
}