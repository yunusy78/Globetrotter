using Entity.Concrete;

namespace DataAccess.Abstract;

public interface IReservationDal : IGenericDal<Reservation>
{
    List<Reservation> GetListWithDestination(string id);
    
}