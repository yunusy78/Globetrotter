using DataAccess.Abstract;
using DataAccess.Concrete;

namespace DataAccess.Repository;

public class GenericRepository<T> : IGenericDal<T> where T : class, new()
{
    private readonly Context _context;
    
    public GenericRepository(Context context)
    {
        _context = context;
    }
    
    
    public void Add(T entity)
    {
        
        _context.Add(entity);
        _context.SaveChanges();
        
    }

    public void Update(T entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T GetById(Guid id)
    {
        return _context.Set<T>().Find(id);
    }
}