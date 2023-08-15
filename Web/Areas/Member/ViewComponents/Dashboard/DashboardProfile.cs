using System.Security.Claims;
using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Member.ViewComponents.Dashboard;

public class DashboardProfile : ViewComponent
{
    
    private readonly  UserManager<ApplicationUser> _um;
    
    public DashboardProfile(UserManager<ApplicationUser> um)
    {
       
        _um = um;
    }
    
    public IViewComponentResult Invoke()
    {
        var user =  _um.GetUserAsync((ClaimsPrincipal)User).Result;
        return View(user);
    }
}