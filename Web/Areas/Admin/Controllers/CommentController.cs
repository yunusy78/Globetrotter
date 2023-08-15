using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class CommentController : Controller
{
    
    
    private readonly ICommentService _commentService;
    
    // GET
    public CommentController(ICommentService commentService)
    {
       
        _commentService = commentService;
    }

    public IActionResult Index()
    {

        var result = _commentService.TGetListWithDestination();
        return View(result);
    }
    
    public IActionResult Delete(Guid id)
    {
        var result = _commentService.GetById(id);
        _commentService.Delete(result);
        return RedirectToAction("Index");
    }
    
    
}