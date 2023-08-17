namespace Web.Areas.Admin.Models;

public class VisitorViewModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Company { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Host { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public string? Notes { get; set; }
    public bool IsCheckedOut { get; set; }

}