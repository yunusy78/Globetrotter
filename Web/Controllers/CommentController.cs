using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[Authorize]
public class CommentController : Controller
{
   
    private readonly ICommentService _commentService;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly Context _context;
    
    public CommentController(ICommentService commentService, 
        UserManager<ApplicationUser> userManager, Context context)
    {
        _commentService = commentService;
        _userManager = userManager;
        _context = context;
    }
    
   
    
    [HttpPost]
    public IActionResult AddComment(Comment comment)
    {
        var user = _userManager.GetUserAsync(User).Result;
        comment.CreatedAt= DateTime.Now;
        comment.CommentState = true;
        comment.UserId = user!.Id;
        if(comment.Name == null)
        {
            comment.Name = user!.UserName;
        }
        
        if(comment.Email == null)
        {
            comment.Email = user!.Email;
        }   
        _commentService.Add(comment);
        return RedirectToAction("Details" ,"Destination", new {id = comment.DestinationId});
    }
    
    
    
}