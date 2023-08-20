using DataAccess.Concrete;
using Entity.Concrete;
using MediatR;
using Web.CQRS.Commants.GuideCommands;

namespace Web.CQRS.Handlers.GuidHandlers;

public class CreateGuidCommandHandler : IRequestHandler<CreateGuidCommand>
{
    private readonly Context _context;
    
    public CreateGuidCommandHandler(Context context)
    {
        _context = context;
    }
    
    
    public async Task<Unit> Handle(CreateGuidCommand request, CancellationToken cancellationToken)
    {
        _context.Guides.Add(new Guide
        {
            FullName = request.FullName,
            Description = request.Description,
            Email = request.Email,
            Status = true
        });
        await _context.SaveChangesAsync(cancellationToken);
          return Unit.Value;
    }
}