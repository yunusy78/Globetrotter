using Microsoft.AspNetCore.Mvc;
using Web.CQRS.Commants.DestinationCommands;
using Web.CQRS.Handlers;
using Web.CQRS.Queries.DestinationQueries;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class DestinationCqrsController : Controller
{
    private readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler;
    private readonly GetDestinationByIdQueryHandler _getDestinationByIdQueryHandler;
    private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
    private readonly DeleteDestinationCommandHandler _deleteDestinationCommandHandler;
    private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
    
    public DestinationCqrsController(GetAllDestinationQueryHandler getAllDestinationQueryHandler, 
        GetDestinationByIdQueryHandler getDestinationByIdQueryHandler, 
        CreateDestinationCommandHandler createDestinationCommandHandler, 
        DeleteDestinationCommandHandler deleteDestinationCommandHandler, 
        UpdateDestinationCommandHandler updateDestinationCommandHandler)
    {
        _getAllDestinationQueryHandler = getAllDestinationQueryHandler;
        _getDestinationByIdQueryHandler = getDestinationByIdQueryHandler;
        _createDestinationCommandHandler = createDestinationCommandHandler;
        _deleteDestinationCommandHandler = deleteDestinationCommandHandler;
        _updateDestinationCommandHandler = updateDestinationCommandHandler;
    }
    
    
    // GET
    public IActionResult Index()
    {
        var destinations = _getAllDestinationQueryHandler.Handle();
        return View(destinations);
    }
    
    public IActionResult Details(Guid id)
    {
        var destination = _getDestinationByIdQueryHandler.Handle(new GetDestinationByIdQuery(id));
        return View(destination);
    }
    
    [HttpPost]
    public IActionResult Details(UpdateDestinationCommand command)
    {
        _updateDestinationCommandHandler.Handle(command);
        return RedirectToAction("Index");
    }
    
    
    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Add(CreateDestinationCommand command)
    {
        _createDestinationCommandHandler.Handle(command);
        return RedirectToAction("Index");
    }
    
    public IActionResult Delete(Guid id)
    {
       _deleteDestinationCommandHandler.Handle(new DeleteDestinationCommand(id));
         return RedirectToAction("Index");
    }
    
    
    
    
}