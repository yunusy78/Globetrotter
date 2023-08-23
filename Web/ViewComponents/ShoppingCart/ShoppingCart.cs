using System.Security.Claims;
using DataAccess.Abstract;
using Entity.Concrete;
using Fresh724.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.ShoppingCart;

public class ShoppingCart : ViewComponent
{
    private readonly UserManager<ApplicationUser> _um;

    private readonly IShoppingCartDal _shoppingCartDal;


    public ShoppingCart(UserManager<ApplicationUser> um, IShoppingCartDal shoppingCartDal)
    {
        _um = um;
        _shoppingCartDal = shoppingCartDal;
    }

    public IViewComponentResult Invoke()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
        var user = _um.GetUserAsync((ClaimsPrincipal)User).Result;
        if (user != null)
        {
            if (HttpContext.Session.GetInt32(PaymentService.SessionCart) != null)
            {
                return View(HttpContext.Session.GetInt32(PaymentService.SessionCart));
            }
            else
            {
                HttpContext.Session.SetInt32(PaymentService.SessionCart,
                    _shoppingCartDal.GetAllListByFilter(u => u.UserId == claim.Value).ToList().Count);
                return View(HttpContext.Session.GetInt32(PaymentService.SessionCart));
            }
        }
        else
        {
            HttpContext.Session.Clear();
            return View(0);
        }
    }
    
}