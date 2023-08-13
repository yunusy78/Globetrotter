using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Default;

public class Testimonial : ViewComponent
{
    private readonly Context _context;

    private readonly TestimonialManager _testimonialManager;
    
    
    public Testimonial(Context context)
    {
        _context = context;
        
        _testimonialManager = new TestimonialManager(new EfTestimonialDal(context));
    }
    
    
    public IViewComponentResult Invoke()
    {
        
        var testimonialList = _testimonialManager.GetAll();
        return View(testimonialList);
    }
}