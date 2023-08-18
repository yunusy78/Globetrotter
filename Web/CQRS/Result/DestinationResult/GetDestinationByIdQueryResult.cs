namespace Web.CQRS.Result.DestinationResult;

public class GetDestinationByIsQueryResult
{
    public Guid Id { get; set; }
    public string? City { get; set; }
    public string? DayNight { get; set; }
    
}