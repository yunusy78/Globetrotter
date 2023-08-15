using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete;

public class Reservation
{
    public Guid Id { get; set; }
    
    public string?  UserId  { get; set; }
    
    public ApplicationUser? User { get; set; }
    
    public int PersonCount { get; set; }
    
    public DateTime ReservationDate { get; set; }
    
    public Destination? Destination { get; set; }
    
    public Guid DestinationId { get; set; }
    [ForeignKey("DestinationId")]
    
    public string? Status { get; set; }
    
    public double TotalPrice { get; set; }
}