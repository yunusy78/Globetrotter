namespace Entity.Concrete;

public class Message 
{
    public Guid Id { get; set; }= Guid.NewGuid();
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Subject { get; set; }
    public string? MessageText { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool IsRead { get; set; } = false;
    
}