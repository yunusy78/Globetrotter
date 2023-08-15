using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class GuideManager : IGuideService
{
private readonly IGuideDal _guideDal;

public GuideManager(IGuideDal guideDal)
{
    _guideDal = guideDal;
}
    
    public void Add(Guide entity)
    {
        _guideDal.Add(entity);
        
    }

    public void Update(Guide entity)
    {
        _guideDal.Update(entity);
    }

    public void Delete(Guide entity)
    {
        _guideDal.Delete(entity);
    }

    public List<Guide> GetAll()
    {
        return _guideDal.GetAll();
    }

    public Guide GetById(Guid id)
    {
        return _guideDal.GetById(id);
    }

    public List<Guide> GetListByFilter(Expression<Func<Guide, bool>> filter)
    {
        return _guideDal.GetListByFilter(filter);
    }
}