using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class NewsletterManager : INewsletterService
{
    INewsletterDal _newsletterDal;
    
    public NewsletterManager(INewsletterDal newsletterDal)
    {
        _newsletterDal = newsletterDal;
    }
    
    public void Add(Newsletter entity)
    {
        _newsletterDal.Add(entity);
    }

    public void Update(Newsletter entity)
    {
        _newsletterDal.Update(entity);
    }

    public void Delete(Newsletter entity)
    {
        _newsletterDal.Delete(entity);
    }

    public List<Newsletter> GetAll()
    {
      return _newsletterDal.GetAll();
    }

    public Newsletter GetById(Guid id)
    {
       return _newsletterDal.GetById(id);
    }

    public List<Newsletter> GetListByFilter(Expression<Func<Newsletter, bool>> filter)
    {
        return _newsletterDal.GetListByFilter(filter);
    }
}