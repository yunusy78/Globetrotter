using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class SubAboutManager : ISubAboutService
{
    ISubAboutDal _subAboutDal;
    
    public SubAboutManager(ISubAboutDal subAboutDal)
    {
        _subAboutDal = subAboutDal;
    }
    
    public void Add(SubAbout entity)
    {
        _subAboutDal.Add(entity);
    }

    public void Update(SubAbout entity)
    {
        _subAboutDal.Update(entity);
    }

    public void Delete(SubAbout entity)
    {
        _subAboutDal.Delete(entity);
    }

    public List<SubAbout> GetAll()
    {
        return _subAboutDal.GetAll();
    }

    public SubAbout GetById(Guid id)
    {
        return _subAboutDal.GetById(id);
    }

    public List<SubAbout> GetListByFilter(Expression<Func<SubAbout, bool>> filter)
    {
        throw new NotImplementedException();
    }
}