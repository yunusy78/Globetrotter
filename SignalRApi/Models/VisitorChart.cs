namespace SignalRApi.Model;

public class VisitorChart
{
    public VisitorChart()
    {
        VisitCount = new List<int>();
    }
    
    public DateTime Date { get; set; }
    public List<int> VisitCount { get; set; }
}