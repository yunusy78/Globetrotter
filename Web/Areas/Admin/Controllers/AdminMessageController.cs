using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class AdminMessageController : Controller
{
    IMessageService _messageService;
    
    public AdminMessageController(IMessageService messageService)
    {
        _messageService = messageService;
    }
    
    
    // GET
    public IActionResult Index()
    {
       var result= _messageService.GetAll();
        return View(result);
    }
    
    public IActionResult Delete(Guid id)
    {
        var result = _messageService.GetById(id);
        _messageService.Delete(result);
        return RedirectToAction("Index");
    }
    
    public IActionResult Update(Guid id)
    {
        var result = _messageService.GetById(id);
        return View(result);
    }
    
    [HttpPost]
    public IActionResult Update(Message message)
    {
        message.CreatedAt = message.CreatedAt;
        message.IsRead = message.IsRead;
        _messageService.Update(message);
        return RedirectToAction("Index");
    }
    
    public IActionResult Active(Guid id)
    {
        var result = _messageService.GetById(id);
        result.IsRead = true;
        _messageService.Update(result);
        return RedirectToAction("Index");
    }
    
    public IActionResult Passive(Guid id)
    {
        var result = _messageService.GetById(id);
        result.IsRead = false;
        _messageService.Update(result);
        return RedirectToAction("Index");
    }
    
    
    
}