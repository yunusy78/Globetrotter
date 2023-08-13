using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete;

public class Destination
{
    [Key]
    public Guid Id { get; set; }= Guid.NewGuid(); 
    public string? City { get; set; }
    public string? DayNight { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public double Price { get; set; }
    public bool Status { get; set; }
    public int Capacity { get; set; }
    
    public string? CoverImageUrl { get; set; }
    
    public string? Details1 { get; set; }
    public string? Details2 { get; set; }
    public string? ImageUrl2 { get; set; }
    
    public List<Comment> Comments { get; set; }
    
}