using Entity.Concrete;

namespace DataAccess.Abstract;

public interface ICommentDal : IGenericDal<Comment>
{
    
    public List<Comment> GetListWithDestination();

    public List<Comment> TGetListWithDestination();
    
    public List<Comment> GetListWithDestinationAndApplicationUser();

}