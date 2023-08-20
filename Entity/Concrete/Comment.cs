using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete;

public class Comment
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Message { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool CommentState { get; set; } 
    public Guid DestinationId { get; set; }
    [ForeignKey("DestinationId")]
    public Destination Destination { get; set; }
    
    public string? UserId { get; set; }
    [ForeignKey("UserId")]
    public ApplicationUser User { get; set; }
    
}