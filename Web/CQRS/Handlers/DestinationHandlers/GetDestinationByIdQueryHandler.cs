using DataAccess.Concrete;
using Web.CQRS.Queries.DestinationQueries;
using Web.CQRS.Result.DestinationResult;

namespace Web.CQRS.Handlers;

public class GetDestinationByIdQueryHandler
{
    private readonly Context _context;
    
    public GetDestinationByIdQueryHandler(Context context)
    {
        _context = context;
    }
    
    public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
    {
        var destination = _context.Destinations.Find(query.DestinationId);
        return new GetDestinationByIdQueryResult
        {
            Id = destination.Id,
            City = destination.City,
            DayNight = destination.DayNight,
            Price = destination.Price,
            Capacity = destination.Capacity
        };
    }
}