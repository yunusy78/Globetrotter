namespace Web.CQRS.Commants.DestinationCommands;

public class UpdateDestinationCommand
{
    
    public Guid Id { get; set; }
    public string? City { get; set; }
    public string? DayNight { get; set; }
    public double Price { get; set; }
    
    public int Capacity { get; set; }
    
    
    
}