using MediatR;

namespace Web.CQRS.Commants.GuideCommands;

public class UpdateGuidCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
}