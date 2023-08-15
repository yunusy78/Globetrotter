using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents.Default;

public class Testimonial : ViewComponent
{
    

    private readonly ITestimonialService _testimonialManager;
    
    
    public Testimonial(ITestimonialService testimonialManager)
    {
        _testimonialManager = testimonialManager;
    }
    
    public IViewComponentResult Invoke()
    {
        
        var testimonialList = _testimonialManager.GetAll();
        return View(testimonialList);
    }
}