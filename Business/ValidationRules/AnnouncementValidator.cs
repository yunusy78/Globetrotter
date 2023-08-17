using DTO.DTOs.AnnouncementDTOs;
using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules;

public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
{
    public AnnouncementValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Tittel skal ikke være tom");
        RuleFor(x => x.Content).NotEmpty().WithMessage("Innhold skal ikke være tom");
        RuleFor(x=>x.Title).MinimumLength(3).WithMessage("Tittel skal være minst 3 karakterer");
        RuleFor(x=>x.Content).MinimumLength(10).WithMessage("Innhold skal være minst 10 karakterer");
        RuleFor(x=>x.Title).MaximumLength(50).WithMessage("Tittel skal være maks 50 karakterer");
        RuleFor(x=>x.Content).MaximumLength(1000).WithMessage("Innhold skal være maks 1000 karakterer");
    }
    
}