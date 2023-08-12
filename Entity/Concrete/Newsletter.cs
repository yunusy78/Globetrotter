using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete;

public class Newsletter
{
    [Key]
   
    public Guid Id { get; set; }= Guid.NewGuid(); 
    public string? Email { get; set; }
    public bool Status { get; set; }
}