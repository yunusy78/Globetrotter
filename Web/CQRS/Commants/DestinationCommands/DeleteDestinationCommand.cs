namespace Web.CQRS.Commants.DestinationCommands;

public class DeleteDestinationCommand
{
    public DeleteDestinationCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
    
    
    
}