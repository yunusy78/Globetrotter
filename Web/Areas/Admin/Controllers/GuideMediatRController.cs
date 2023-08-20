using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.CQRS.Commants.GuideCommands;
using Web.CQRS.Queries.GuidQueries;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class GuideMediatRController : Controller
{
    public readonly IMediator _mediator;
    
    public GuideMediatRController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    
    // GET
    public async Task<IActionResult> Index()
    {
        var result = await _mediator.Send(new GetAllGuidQuery());
        return View(result);
    }
    
    public async Task<IActionResult> Update(Guid id)
    {
        var result = await _mediator.Send(new GetByIdGuidQuery(id));
        return View(result);
    }
    
    
[HttpPost]
   public async Task<IActionResult> Update(UpdateGuidCommand command)
    {
        await _mediator.Send(command);
        return RedirectToAction("Index");
    }
   
   
   
   public async Task<IActionResult> Delete(Guid id)
   {
       await _mediator.Send(new DeleteGuidCommand(id));
       return RedirectToAction("Index");
   }
   
    
    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Add(CreateGuidCommand command)
    {
        await _mediator.Send(command);
        return RedirectToAction("Index");
    }
}