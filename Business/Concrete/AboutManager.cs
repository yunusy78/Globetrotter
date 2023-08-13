using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class AboutManager : IAboutService
{
    IAboutDal _aboutDal;
    
    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }
    
    
    public void Add(About entity)
    {
        _aboutDal.Add(entity);
    }

    public void Update(About entity)
    {
        _aboutDal.Update(entity);
    }

    public void Delete(About entity)
    {
        _aboutDal.Delete(entity);
    }

    public List<About> GetAll()
    {
        return _aboutDal.GetAll();
    }

    public About GetById(Guid id)
    {
        return _aboutDal.GetById(id);
    }

    public List<About> GetListByFilter(Expression<Func<About, bool>> filter)
    {
        throw new NotImplementedException();
    }
}