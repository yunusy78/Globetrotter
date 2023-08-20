using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete;

public class Guide
{
    [Key]
    public Guid Id { get; set; }= Guid.NewGuid(); 
    public string? FullName { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    
    public bool Status { get; set; }
    public string? Email { get; set; }
    public string? InstagramUrl { get; set; }
    public string? FacebookUrl { get; set; }
    public string? TwitterUrl { get; set; }
    
    public Guid DestinationId { get; set; }
    
    public Destination? Destination { get; set; }
}