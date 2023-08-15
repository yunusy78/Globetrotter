using Business.Abstract;
using Business.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Context = DataAccess.Concrete.Context;

namespace Web.Controllers;

public class DestinationController : Controller
{
    
    private readonly IDestinationService _destinationManager;
    
    public DestinationController( IDestinationService destinationManager)
    {
        _destinationManager = destinationManager;
    }
   
    
    // GET
    public IActionResult Index()
    {
        var destinations = _destinationManager.GetAll();
        return View(destinations);
    }
    
    public IActionResult Details(Guid id)
    {
        ViewBag.DestinationId = id;
        var destination = _destinationManager.GetById(id);
        return View(destination);
    }
    
    [HttpPost]
    public IActionResult Details(Destination destination)
    {
        
        return RedirectToAction("Index");
    }
    
     
}