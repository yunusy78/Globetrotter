using Microsoft.EntityFrameworkCore;
using Web.API.DAL.Entities;

namespace Web.API.DAL.Context;

public class Context:DbContext
{
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Server=127.0.0.1;Database=globetrotterAPIDb;User Id=root;Password=4922;");
    }
    
    public DbSet<Visitor> Visitors { get; set; }
    
}