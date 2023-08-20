using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules;

public class GuideValidator : AbstractValidator<Guide>
{
    public GuideValidator()
    {
        RuleFor(x => x.FullName).NotEmpty().WithMessage("Navn kan ikke være tom");
        RuleFor(x => x.Email).NotEmpty().WithMessage("E-post kan ikke være tom");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Beskrivelse kan ikke være tom");
        
    }
}