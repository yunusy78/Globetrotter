using Entity.Concrete;

namespace Business.Abstract;

public interface IGuideService : IGenericService<Guide>
{
    List<Guide> GetListWithDestination();
    public List<Guide> GetListByDestinationId(Guid id);
    
}