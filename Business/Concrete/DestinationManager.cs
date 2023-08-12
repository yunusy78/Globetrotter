using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class DestinationManager : IDestinationService
{
    IDestinationDal _destinationDal;
    
    public DestinationManager(IDestinationDal destinationDal)
    {
        _destinationDal = destinationDal;
    }
    
    public void Add(Destination entity)
    {
        _destinationDal.Add(entity);
    }

    public void Update(Destination entity)
    {
        _destinationDal.Update(entity);
    }

    public void Delete(Destination entity)
    {
        _destinationDal.Delete(entity);
    }

    public List<Destination> GetAll()
    {
        return _destinationDal.GetAll();
    }

    public Destination GetById(Guid id)
    {
        return _destinationDal.GetById(id);
    }
}