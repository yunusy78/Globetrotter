using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Comment;

public class CommentList : ViewComponent
{
    private readonly ICommentService _commentService;
    
    public CommentList(ICommentService commentService)
    {
        _commentService = commentService;
    }
    
    public IViewComponentResult Invoke(Guid id)
    {
        var comments = _commentService.GetListWithDestinationAndApplicationUser();
        var result = comments.Where(x => x.DestinationId == id).ToList();
        return View(result);
    }
    
}