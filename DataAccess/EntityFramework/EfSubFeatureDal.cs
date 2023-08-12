using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;

namespace DataAccess.Repository;

public class EfSubFeatureDal : GenericRepository<SubFeature> , ISubFeatureDal
{
    public EfSubFeatureDal(Context context) : base(context)
    {
    }
}