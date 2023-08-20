using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class CommentManager : ICommentService
{
    private readonly ICommentDal _commentDal;

    public CommentManager(ICommentDal commentDal)
    {
        _commentDal = commentDal;
    }

    public void Add(Comment comment)
    {
        _commentDal.Add(comment);
    }

    public void Delete(Comment comment)
    {
        _commentDal.Delete(comment);
    }

    public void Update(Comment comment)
    {
        _commentDal.Update(comment);
    }

    public List<Comment> GetAll()
    {
        return _commentDal.GetAll();
    }

    public Comment GetById(Guid id)
    {
        return _commentDal.GetById(id);
    }
    
    public List<Comment> GetListByFilter(Expression<Func<Comment, bool>> filter)
    {
        return _commentDal.GetListByFilter(filter);
    }
    
    public List<Comment> GetDestinationById (Guid id)
    {
        return _commentDal.GetListByFilter(x => x.DestinationId == id);
    }

    public List<Comment> TGetListWithDestination()
    {
        return _commentDal.TGetListWithDestination();
    }

    public List<Comment> GetListWithDestinationAndApplicationUser()
    {
        return _commentDal.GetListWithDestinationAndApplicationUser();
    }
}