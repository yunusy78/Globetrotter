using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework;

public class EfReservationDal : GenericRepository<Reservation> , IReservationDal
{
   
    
    public List<Reservation> GetListWithDestination(string id)
    {
        using var _context = new Context();
        return _context.Reservations.Where(x => x.UserId == id).Include(x => x.Destination).ToList();
    }
}