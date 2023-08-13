using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Default;

public class PopularDestination : ViewComponent
{
    private readonly DestinationManager _destinationManager;
    private readonly Context _db;
    
    public PopularDestination(Context db)
    {
        _db = db;
        _destinationManager = new DestinationManager(new EfDestinationDal(_db));
    }
    
    
    public IViewComponentResult Invoke()
    {
        var result = _destinationManager.GetAll();
        return View(result);
    }
    
    
}