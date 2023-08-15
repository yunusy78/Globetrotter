using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Comment;

public class CommentList : ViewComponent
{
    private readonly ICommentService _commentManager;
    
    public CommentList(ICommentService commentManager)
    {
        _commentManager = commentManager;
    }
    
    public IViewComponentResult Invoke(Guid id)
    {
        var result = _commentManager.GetDestinationById(id);
        return View(result);
    }
    
}