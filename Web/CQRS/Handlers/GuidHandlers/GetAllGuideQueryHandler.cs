using DataAccess.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Web.CQRS.Queries.GuidQueries;
using Web.CQRS.Result.GuidResult;

namespace Web.CQRS.Handlers.GuidHandlers;

public class GetAllGuideQueryHandler: IRequestHandler<GetAllGuidQuery, List<GetAllGuidQueryResult>>
{
    private readonly Context _context;


    public GetAllGuideQueryHandler(Context context)
    {
        _context = context;
    }

    public async Task<List<GetAllGuidQueryResult>> Handle(GetAllGuidQuery request, CancellationToken cancellationToken)
    {
        return await _context.Guides.Select(x => new GetAllGuidQueryResult
        {
            Id = x.Id,
            Description = x.Description,
            ImageUrl = x.ImageUrl,
            FullName = x.FullName,
            Email = x.Email


        }).AsNoTracking().ToListAsync();
    }
}