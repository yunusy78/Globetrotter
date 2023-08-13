using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Comment;

public class CommentList : ViewComponent
{
    private readonly Context _context;
    private readonly CommentManager _commentManager;
    
    public CommentList(Context context)
    {
        _context = context;
        _commentManager = new CommentManager(new EfCommentDal(_context));
    }
    
    public IViewComponentResult Invoke(Guid id)
    {
        var result = _commentManager.GetDestinationById(id);
        return View(result);
    }
    
}