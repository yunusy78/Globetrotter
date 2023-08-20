namespace Web.CQRS.Result.GuidResult;

public class GetGuidByIdQueryResult
{
    public Guid Id { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    
}