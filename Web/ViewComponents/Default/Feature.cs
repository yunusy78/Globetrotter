using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Default;

public class Feature : ViewComponent
{
    private readonly FeatureManager _featureManager;
    private readonly Context _context;
    
    public Feature(Context context)
    {
        _featureManager = new FeatureManager(new EfFeatureDal(context));
        _context = context;
    }
    
    
    public IViewComponentResult Invoke()
    {
        var result = _featureManager.GetAll();
        return View(result);
    }
    
}