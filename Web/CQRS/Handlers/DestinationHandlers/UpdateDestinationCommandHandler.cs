using DataAccess.Concrete;
using Web.CQRS.Commants.DestinationCommands;

namespace Web.CQRS.Handlers;

public class UpdateDestinationCommandHandler
{
    private readonly Context _context;
    
    public UpdateDestinationCommandHandler(Context context)
    {
        _context = context;
    }
    
    public void Handle(UpdateDestinationCommand command)
    {
        var destination = _context.Destinations.Find(command.Id);
        destination!.City = command.City;
        destination.DayNight = command.DayNight;
        destination.Price = command.Price;
        destination.Capacity = command.Capacity;
        _context.SaveChanges();
    }
    
}