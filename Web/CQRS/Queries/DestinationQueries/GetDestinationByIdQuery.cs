namespace Web.CQRS.Queries.DestinationQueries;

public class GetDestinationByIdQuery
{
    public GetDestinationByIdQuery(Guid destinationId)
    {
        DestinationId = destinationId;
    }

    public Guid DestinationId { get; set; }
    
    
    
    
    
}