using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class ContactManager : IContactService
{
    IContactDal _contactDal;
    
    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }
    
    public void Add(Contact entity)
    {
        _contactDal.Add(entity);
    }

    public void Update(Contact entity)
    {
        _contactDal.Update(entity);
    }

    public void Delete(Contact entity)
    {
        _contactDal.Delete(entity);
    }

    public List<Contact> GetAll()
    {
        return _contactDal.GetAll();
    }

    public Contact GetById(Guid id)
    {
        return _contactDal.GetById(id);
    }

    public List<Contact> GetListByFilter(Expression<Func<Contact, bool>> filter)
    {
        throw new NotImplementedException();
    }
}