using System.Linq.Expressions;

namespace DataAccess.Abstract;

public interface IGenericDal<T> where T : class, new()
{
    public void Add(T entity);
    public void Update(T entity);
    public void Delete(T entity);
    public List<T> GetAll();
    public T GetById(Guid id);
    
    List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    
}