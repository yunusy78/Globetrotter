using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete;

public class Testimonial
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid(); 
    public string? Name { get; set; }
    public string? Comment { get; set; }
    public string? ImageUrl { get; set; }
    public bool Status { get; set; }
}