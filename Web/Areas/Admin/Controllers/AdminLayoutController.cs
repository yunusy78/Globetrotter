using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers;

public class AdminLayoutController : Controller
{
    // GET
    public PartialViewResult Header()
    {
        return PartialView();
    }
    
    public PartialViewResult AppBrandDemo()
    {
        return PartialView();
    }
    
    public PartialViewResult Sidebar()
    {
        return PartialView();
    }
    
    public PartialViewResult NavBar()
    {
        return PartialView();
    }
    
    public PartialViewResult Footer()
    {
        return PartialView();
    }
    
    public PartialViewResult Script()
    {
        return PartialView();
    }
    
    
    
}