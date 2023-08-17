using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class AnnouncementManager :IAnnouncementService
{
    private readonly IAnnouncementDal _announcementDal;
    
    public AnnouncementManager(IAnnouncementDal announcementDal)
    {
        _announcementDal = announcementDal;
    }
    public void Add(Announcement entity)
    {
        _announcementDal.Add(entity);
    }

    public void Update(Announcement entity)
    {
       _announcementDal.Update(entity);
    }

    public void Delete(Announcement entity)
    {
        _announcementDal.Delete(entity);
    }

    public List<Announcement> GetAll()
    {
        return _announcementDal.GetAll();
    }

    public Announcement GetById(Guid id)
    {
        return _announcementDal.GetById(id);
    }

    public List<Announcement> GetListByFilter(Expression<Func<Announcement, bool>> filter)
    {
        return _announcementDal.GetListByFilter(filter);
    }
}