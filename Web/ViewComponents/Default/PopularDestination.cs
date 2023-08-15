using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Default;

public class PopularDestination : ViewComponent
{
    private readonly IDestinationService _destinationManager;
    
    public PopularDestination(IDestinationService destinationManager)
    {
        _destinationManager = destinationManager;
    }
    
    
    public IViewComponentResult Invoke()
    {
        var result = _destinationManager.GetAll();
        return View(result);
    }
    
    
}