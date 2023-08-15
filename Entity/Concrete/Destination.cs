using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Concrete;

public class Destination
{

    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "Byen er påkrevd")]
    public string? City { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Dag-Natt kan ikke overstige 100 tegn")]
    public string? DayNight { get; set; }

    [Required]
    [StringLength(200, ErrorMessage = "Beskrivelse kan ikke overstige 200 tegn")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Bilde-URL er påkrevd")]
    [Url(ErrorMessage = "Ugyldig bilde-URL-format")]
    public string? ImageUrl { get; set; }
    
    [Url(ErrorMessage = "Ugyldig bilde-URL-format")]
    public string? ImageUrl2 { get; set; }

    [Range(1, 300000, ErrorMessage = "Prisen må være mellom 1 og 1000000")]
    public double Price { get; set; }

    [Required(ErrorMessage = "Status er påkrevd")]
    public bool Status { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Kapasiteten må være positiv")]
    public int Capacity { get; set; }

  
    [Url(ErrorMessage = "Ugyldig omslagsbilde-URL-format")]
    public string? CoverImageUrl { get; set; }

    [StringLength(3000, ErrorMessage = "Detalj 1 kan ikke overstige 200 tegn")]
    public string? Details1 { get; set; }

    [StringLength(3000, ErrorMessage = "Detalj 2 kan ikke overstige 200 tegn")]
    public string? Details2 { get; set; }

    public List<Comment>? Comments { get; set; }

    public List<Reservation>? Reservations { get; set; }
    
    
}

    