using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Web.CQRS.Result.DestinationResult;

namespace Web.CQRS.Handlers;

public class GetAllDestinationQueryHandler
{
    private readonly Context _context;
    
    public GetAllDestinationQueryHandler(Context context)
    {
        _context = context;
    }

    public List<GetAllDestinationQueryResult> Handle()
    {
        var destinations = _context.Destinations.Select(x => new GetAllDestinationQueryResult
        {
            Id = x.Id,
            City = x.City,
            Price = x.Price,
            Capacity = x.Capacity,
            DayNight = x.DayNight
        }).AsNoTracking().ToList();
        
        return destinations;

    }




}