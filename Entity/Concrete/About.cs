using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Entity.Concrete;

public class About
{
    [Key]
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string? Title2 { get; set; }
    public string? Description2 { get; set; }
    public string? VideoUrl { get; set; }
    public bool Status { get; set; }
    
}