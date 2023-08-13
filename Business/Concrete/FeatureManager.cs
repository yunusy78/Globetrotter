using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class FeatureManager : IFeatureService
{
    IFeatureDal _featureDal;
    
    public FeatureManager(IFeatureDal featureDal)
    {
        _featureDal = featureDal;
    }
    
    public void Add(Feature entity)
    {
        _featureDal.Add(entity);
    }

    public void Update(Feature entity)
    {
        _featureDal.Update(entity);
    }

    public void Delete(Feature entity)
    {
        _featureDal.Delete(entity);
    }

    public List<Feature> GetAll()
    {
        return _featureDal.GetAll();
    }

    public Feature GetById(Guid id)
    {
        return _featureDal.GetById(id);
    }

    public List<Feature> GetListByFilter(Expression<Func<Feature, bool>> filter)
    {
        throw new NotImplementedException();
    }
}