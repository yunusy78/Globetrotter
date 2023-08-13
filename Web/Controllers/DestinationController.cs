using Business.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Context = DataAccess.Concrete.Context;

namespace Web.Controllers;

public class DestinationController : Controller
{
    private readonly Context _context;
    private readonly DestinationManager _destinationManager;
    
    public DestinationController(Context context)
    {
        _context = context;
        _destinationManager = new DestinationManager(new EfDestinationDal(_context));
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