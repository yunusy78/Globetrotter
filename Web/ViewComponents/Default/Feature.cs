using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Default;

public class Feature : ViewComponent
{
    private readonly IFeatureService _featureManager;
    
    public Feature(IFeatureService featureManager)
    {
        _featureManager = featureManager;
    }
    
    
    
    public IViewComponentResult Invoke()
    {
        var result = _featureManager.GetAll();
        return View(result);
    }
    
}