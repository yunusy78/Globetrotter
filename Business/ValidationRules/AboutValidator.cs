using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules;

public class AboutValidator: AbstractValidator<About>
{
    public AboutValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Title kan ikke være tom");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Beskrivelse kan ikke være tom");
        RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Bilde kan ikke være tom");
        RuleFor(x=>x.Title).MinimumLength(3).WithMessage("Tittel må være minst 3 tegn");
        RuleFor(x=>x.Description).MinimumLength(10).WithMessage("Beskrivelse må være minst 10 tegn");
        RuleFor(x=>x.ImageUrl).MinimumLength(3).WithMessage("Bilde må være minst 10 tegn");
    }
}