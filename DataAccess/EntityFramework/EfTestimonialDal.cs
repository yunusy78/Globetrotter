﻿using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;

namespace DataAccess.Repository;

public class EfTestimonialDal : GenericRepository<Testimonial> , ITestimonialDal
{
    
}