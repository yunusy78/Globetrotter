using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class MessageController : Controller
{
    IMessageDal _messageDal;
    
    public MessageController(IMessageDal messageDal)
    {
        _messageDal = messageDal;
    }
    
    
    // GET
    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    
    public IActionResult Add(Message message)
    {
        message.CreatedAt = DateTime.Now;
        message.IsRead = false;
        _messageDal.Add(message);
        return RedirectToAction("Index", "Default");
    }
}