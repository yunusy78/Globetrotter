using Entity.Concrete;

namespace Business.Abstract;

public interface ICommentService : IGenericService<Comment>
{
    List<Comment> GetDestinationById(Guid id);
    
}