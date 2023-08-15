using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework;

public class EfCommentDal : GenericRepository<Comment>, ICommentDal
{
    

    public List<Comment> GetListWithDestination()
    {
        throw new NotImplementedException();
    }

    public List<Comment> TGetListWithDestination()
    {
        using var _context = new Context();
        return _context.Comments.Include(x => x.Destination).ToList();
    }
}