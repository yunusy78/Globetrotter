using Entity.Concrete;

namespace Business.Abstract;

public interface IReservationService : IGenericService<Reservation>
{
    List<Reservation> GetListWithDestination(string id);
    
}