using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Default;

public class SubAbout : ViewComponent
{
    private readonly Context _context;
    private readonly SubAboutManager _subAboutManager;
    
    public SubAbout(Context context)
    {
        _context = context;
        _subAboutManager = new SubAboutManager(new EfSubAboutDal(context));
    }
    
    
    public IViewComponentResult Invoke()
    {
        var result = _subAboutManager.GetAll();
        return View(result);
    }
    
}