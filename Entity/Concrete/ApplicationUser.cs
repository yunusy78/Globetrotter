using Microsoft.AspNetCore.Identity;

namespace Entity.Concrete;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? ImageUrl { get; set; }
    public string? About { get; set; }
    public string? Gender { get; set; }
    
    public List<Reservation>? Reservations { get; set; }
    public List<Comment>? Comments { get; set; }
    
}