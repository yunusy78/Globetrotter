using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class ReservationManager : IReservationService
{  
    private readonly IReservationDal _reservationDal;
    
public ReservationManager(IReservationDal reservationDal)
    {
        _reservationDal = reservationDal;
    }
    
    public void Add(Reservation entity)
    {
        _reservationDal.Add(entity);
    }

    public void Update(Reservation entity)
    {
        _reservationDal.Update(entity);
    }

    public void Delete(Reservation entity)
    {
       _reservationDal.Delete(entity);
    }

    public List<Reservation> GetAll()
    {
       return _reservationDal.GetAll();
    }

    public Reservation GetById(Guid id)
    {
        return _reservationDal.GetById(id);
    }

    public List<Reservation> GetListByFilter(Expression<Func<Reservation, bool>> filter)
    {
        return _reservationDal.GetListByFilter(filter);
    }

    public List<Reservation> GetListWithDestination(string id)
    {
        return _reservationDal.GetListWithDestination(id);
    }
}