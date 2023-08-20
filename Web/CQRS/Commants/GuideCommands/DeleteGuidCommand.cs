using MediatR;

namespace Web.CQRS.Commants.GuideCommands;

public class DeleteGuidCommand : IRequest<Unit>
{
    public DeleteGuidCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
    
}