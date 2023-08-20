using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class PackagesController : Controller
{
    private readonly IDestinationService _destinationService;
    
    public PackagesController(IDestinationService destinationService)
    {
        _destinationService = destinationService;
    }
    
    
    // GET
    public IActionResult Index()
    {

        var destination = _destinationService.GetAll();
        return View(destination);
    }
}