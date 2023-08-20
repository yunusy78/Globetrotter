using DataAccess.Concrete;
using Entity.Concrete;
using MediatR;
using Web.CQRS.Commants.GuideCommands;

namespace Web.CQRS.Handlers.GuidHandlers;

public class UpdateGuidCommandHandler : IRequestHandler<UpdateGuidCommand>
{
    private readonly Context _context;
    
    public UpdateGuidCommandHandler(Context context)
    {
        _context = context;
    }
    
    public async Task<Unit> Handle(UpdateGuidCommand request, CancellationToken cancellationToken)
    {
        _context.Guides.Update(new Guide
        {
            Id = request.Id,
            Description = request.Description,
            Email = request.Email,
            FullName = request.FullName,
            ImageUrl = request.ImageUrl
        });
       await _context.SaveChangesAsync(cancellationToken);
       return Unit.Value;
        
    }
}