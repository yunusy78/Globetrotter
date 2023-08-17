using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class MessageManager : IMessageService
{
    IMessageDal _messageDal;
    
    public MessageManager(IMessageDal messageDal)
    {
        _messageDal = messageDal;
    }
    
    public void Add(Message entity)
    {
        _messageDal.Add(entity);
    }

    public void Update(Message entity)
    {
        _messageDal.Update(entity);
    }

    public void Delete(Message entity)
    {
        _messageDal.Delete(entity);
    }

    public List<Message> GetAll()
    {
       return _messageDal.GetAll();
    }

    public Message GetById(Guid id)
    {
        return _messageDal.GetById(id);
    }

    public List<Message> GetListByFilter(Expression<Func<Message, bool>> filter)
    {
        return _messageDal.GetListByFilter(filter);
    }
}