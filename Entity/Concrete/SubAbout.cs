using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete;

public class SubAbout
{
    [Key]

    public Guid Id { get; set; }= Guid.NewGuid(); 
    public string? Title { get; set; }
    public string? Description { get; set; }
    
}