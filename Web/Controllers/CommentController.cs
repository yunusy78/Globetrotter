using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class CommentController : Controller
{
   
    private readonly ICommentService _commentManager;
    
    public CommentController(ICommentService commentManager)
    {
        _commentManager = commentManager;
    }
    
    
    // GET
    public PartialViewResult AddComment()
    {
        return PartialView();
    }
    
    [HttpPost]
    public IActionResult AddComment(Comment comment)
    {
        comment.CreatedAt= DateTime.Now;
        comment.CommentState = true;
        //comment.DestinationId =Guid.Parse("a8fce226-4171-40ee-8d00-66cf7e26e173");
        _commentManager.Add(comment);
        return RedirectToAction("Index", "Destination");
    }
    
}