using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Repository;
using Entity.Concrete;

namespace Business.Concrete;

public class TestimonialManager : ITestimonialService
{
    ITestimonialDal _testimonialDal;
    
    public TestimonialManager (ITestimonialDal testimonialDal)
    {
        _testimonialDal = testimonialDal;
    }
    
    public void Add(Testimonial entity)
    {
        _testimonialDal.Add(entity);
    }

    public void Update(Testimonial entity)
    {
        _testimonialDal.Update(entity);
    }

    public void Delete(Testimonial entity)
    {
        _testimonialDal.Delete(entity);
    }

    public List<Testimonial> GetAll()
    {
        return _testimonialDal.GetAll();
    }

    public Testimonial GetById(Guid id)
    {
        return _testimonialDal.GetById(id);
    }

    public List<Testimonial> GetListByFilter(Expression<Func<Testimonial, bool>> filter)
    {
        throw new NotImplementedException();
    }
}