using DataAccess.Concrete;
using Web.CQRS.Commants.DestinationCommands;

namespace Web.CQRS.Handlers;

public class DeleteDestinationCommandHandler
{
    private readonly Context _context;
    
    public DeleteDestinationCommandHandler(Context context)
    {
        _context = context;
    }
    
    
    public void Handle(DeleteDestinationCommand command)
    {
        var destination = _context.Destinations.Find(command.Id);
        _context.Destinations.Remove(destination);
        _context.SaveChanges();
    }
}