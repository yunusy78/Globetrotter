using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Member.ViewComponents.Dashboard;

public class DestinationList : ViewComponent
{
    
    private readonly IDestinationService _destinationManager;
    
    public DestinationList(IDestinationService destinationManager)
    {
        _destinationManager = destinationManager;
    }
    
    public IViewComponentResult Invoke()
    {
        var result = _destinationManager.GetAll().Take(4);
        return View(result);
    }
    
}