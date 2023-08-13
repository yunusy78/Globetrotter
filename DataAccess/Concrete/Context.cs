using System.Security.Cryptography;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete;

public class Context :IdentityDbContext<ApplicationUser>
{
    
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<About> Abouts { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Guide> Guides { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<SubAbout> SubAbouts { get; set; }
    public DbSet<SubFeature> SubFeatures { get; set; }
    public DbSet<Newsletter> Newsletters { get; set; }
    public DbSet<Comment> Comments { get; set; }
    

    
    
}