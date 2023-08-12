using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;

namespace DataAccess.Repository;

public class EfContactDal : GenericRepository<Contact> , IContactDal
{
    public EfContactDal(Context context) : base(context)
    {
    }
}