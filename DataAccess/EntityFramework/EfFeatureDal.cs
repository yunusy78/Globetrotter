using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;

namespace DataAccess.Repository;

public class EfFeatureDal : GenericRepository<Feature> , IFeatureDal
{
    public EfFeatureDal(Context context) : base(context)
    {
    }
}