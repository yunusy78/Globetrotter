namespace Web.Areas.Admin.Models;

public class ExchangeRate
{
    
    public string? New_currency { get; set; }
    public string? Old_currency { get; set; }
    public decimal Old_amount { get; set; }
    public decimal  New_amount { get; set; }
    
}