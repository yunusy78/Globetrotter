using System.Linq.Expressions;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class GenericRepository<T> : IGenericDal<T> where T : class , new()
{
   
    
    
    
    public void Add(T entity)
    {
        using var _context = new Context();
        _context.Add(entity);
        _context.SaveChanges();
        
    }

    public void Update(T entity)
    {
        using var _context = new Context();
        _context.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        using var _context = new Context();
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public List<T> GetAll()
    {
        using var _context = new Context();
        return _context.Set<T>().ToList();
    }

    public T GetById(Guid id)
    {
        using var _context = new Context();
        return _context.Set<T>().Find(id);
    }

    public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
    {
        using var _context = new Context();
        return _context.Set<T>().Where(filter).ToList();
        
    }
}