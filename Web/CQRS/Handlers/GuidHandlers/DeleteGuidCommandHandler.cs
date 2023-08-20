using DataAccess.Concrete;
using MediatR;
using Web.CQRS.Commants.GuideCommands;

namespace Web.CQRS.Handlers.GuidHandlers;

public class DeleteGuidCommandHandler : IRequestHandler<DeleteGuidCommand>
{
    private readonly Context _context;
    
    public DeleteGuidCommandHandler(Context context)
    {
        _context = context;
    }
    public async Task<Unit> Handle(DeleteGuidCommand request, CancellationToken cancellationToken)
    {
        var guide = await _context.Guides.FindAsync(request.Id);
        _context.Guides.Remove(guide!);  
        await _context.SaveChangesAsync(cancellationToken);
        return Unit.Value;
        
    }
}