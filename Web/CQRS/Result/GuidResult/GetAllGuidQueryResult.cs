namespace Web.CQRS.Result.GuidResult;

public class GetAllGuidQueryResult
{
    public Guid Id { get; set; }= Guid.NewGuid(); 
    public string? FullName { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    public string? Email { get; set; }
    
}