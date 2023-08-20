using Entity.Concrete;

namespace DataAccess.Abstract;

public interface IGuideDal:IGenericDal<Guide>
{
    List<Guide> GetListWithDestination();
    public List<Guide> GetListByDestinationId(Guid id);


}