using DataAccess.Concrete;
using MediatR;
using Web.CQRS.Queries.GuidQueries;
using Web.CQRS.Result.GuidResult;

namespace Web.CQRS.Handlers.GuidHandlers;

public class GetGuidByIdQueryHandler : IRequestHandler<GetByIdGuidQuery, GetGuidByIdQueryResult>
{ 
    private readonly Context _context;
    
    public GetGuidByIdQueryHandler(Context context)
    {
        _context = context;
    }
    
    
    public async Task<GetGuidByIdQueryResult> Handle(GetByIdGuidQuery request, CancellationToken cancellationToken)
    {
       var result = await _context.Guides.FindAsync(request.Id);
       return new GetGuidByIdQueryResult
       {
           Id = result!.Id,
           Description = result.Description,
           Email = result.Email,
           FullName = result.FullName,
           ImageUrl = result.ImageUrl

       };
    }
}
