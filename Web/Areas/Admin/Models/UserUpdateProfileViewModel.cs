namespace Web.Areas.Member.Models;

public class UserUpdateProfileViewModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? ImageUrl { get; set; }
    public string? Password { get; set; }
    public string? ConfirmPassword { get; set; }
    
    public string? Gender { get; set; }
    
    public string? About { get; set; }
    
}