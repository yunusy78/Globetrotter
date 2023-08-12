using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete;

public class Feature
{
    [Key]
    public Guid Id { get; set; }= Guid.NewGuid(); 
    public string? Title { get; set; }
    public string? PostDescription { get; set; }
    public string? ImageUrl { get; set; }
    public bool Status { get; set; }
}