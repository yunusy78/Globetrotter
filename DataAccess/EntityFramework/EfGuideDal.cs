using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class EfGuideDal : GenericRepository<Guide> , IGuideDal
{
    public List<Guide> GetListWithDestination()
    {
        using var _context = new Context();
        return _context.Guides.Include(x => x.Destination).ToList();
    }

    public List<Guide> GetListByDestinationId(Guid id)
    {
        using var _context = new Context();
        return _context.Guides.Include(x => x.Destination).Where(x => x.DestinationId == id).ToList();
    }
}