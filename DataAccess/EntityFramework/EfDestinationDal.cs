using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;

namespace DataAccess.Repository;

public class EfDestinationDal : GenericRepository<Destination> , IDestinationDal
{
    public EfDestinationDal(Context context) : base(context)
    {
    }
}