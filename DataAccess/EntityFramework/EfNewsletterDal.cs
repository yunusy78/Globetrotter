using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;

namespace DataAccess.Repository;

public class EfNewsletterDal : GenericRepository<Newsletter> , INewsletterDal
{
    
    
}