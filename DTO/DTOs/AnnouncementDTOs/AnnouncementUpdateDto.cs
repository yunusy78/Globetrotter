namespace DTO.DTOs.AnnouncementDTOs;

public class AnnouncementUpdateDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Title { get; set; }
    public string? Content { get; set; }
    
}