using DataAccess.Concrete;
using Web.CQRS.Commants.DestinationCommands;

namespace Web.CQRS.Handlers;

public class CreateDestinationCommandHandler
{
    private readonly Context _context;
    
    public CreateDestinationCommandHandler(Context context)
    {
        _context = context;
    }
    
    public void Handle(CreateDestinationCommand command)
    {
        var destination = new Entity.Concrete.Destination()
        {
            Id = command.Id,
            City = command.City,
            DayNight = command.DayNight,
            Price = command.Price,
            Capacity = command.Capacity,
            Status = true
        };
        _context.Destinations.Add(destination);
        _context.SaveChanges();
    }
    
}