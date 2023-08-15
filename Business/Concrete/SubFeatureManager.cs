using System.Linq.Expressions;
using Business.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class SubFeatureManager : ISubFeatureService
{
    public void Add(SubFeature entity)
    {
        throw new NotImplementedException();
    }

    public void Update(SubFeature entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(SubFeature entity)
    {
        throw new NotImplementedException();
    }

    public List<SubFeature> GetAll()
    {
        throw new NotImplementedException();
    }

    public SubFeature GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<SubFeature> GetListByFilter(Expression<Func<SubFeature, bool>> filter)
    {
        throw new NotImplementedException();
    }
}