using MediatR;

namespace Web.CQRS.Commants.GuideCommands;

public class CreateGuidCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
    public string? Description { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public bool Status { get; set; }
    
}