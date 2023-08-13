using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;

namespace DataAccess.EntityFramework;

public class EfCommentDal : GenericRepository<Comment>, ICommentDal
{
    public EfCommentDal(Context context) : base(context)
    {
    }
}