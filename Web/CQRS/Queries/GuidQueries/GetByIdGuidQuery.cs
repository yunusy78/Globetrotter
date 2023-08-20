using MediatR;
using Web.CQRS.Result.GuidResult;

namespace Web.CQRS.Queries.GuidQueries;

public class GetByIdGuidQuery : IRequest<GetGuidByIdQueryResult>
{
    public GetByIdGuidQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
    
    
}