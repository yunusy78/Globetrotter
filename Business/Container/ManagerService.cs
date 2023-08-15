using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using DataAccess.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Container;

public static class ManagerService
{
    public static void ContainerDependencies(this IServiceCollection Services)

    {
        
        Services.AddScoped<ICommentService, CommentManager>();
        Services.AddScoped<ICommentDal, EfCommentDal>();
        Services.AddScoped<IDestinationService, DestinationManager>();
        Services.AddScoped<IDestinationDal, EfDestinationDal>();
        Services.AddScoped<IFeatureService, FeatureManager>();
        Services.AddScoped<IFeatureDal, EfFeatureDal>();
        Services.AddScoped<IReservationService, ReservationManager>();
        Services.AddScoped<IReservationDal, EfReservationDal>();
        Services.AddScoped<ISubAboutService, SubAboutManager>();
        Services.AddScoped<ISubAboutDal, EfSubAboutDal>();
        Services.AddScoped<ITestimonialService, TestimonialManager>();
        Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
        Services.AddScoped<IAboutService, AboutManager>();
        Services.AddScoped<IAboutDal, EfAboutDal>();
        Services.AddScoped<IGuideDal, EfGuideDal>();
       Services.AddScoped<IGuideService, GuideManager>();
       Services.AddScoped<ISubFeatureService, SubFeatureManager>();
       Services.AddScoped<ISubFeatureDal, EfSubFeatureDal>();
       Services.AddScoped<IContactDal, EfContactDal>();
       Services.AddScoped<IContactService, ContactManager>();
    }
    
}