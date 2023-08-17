using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules;

public class ApplicationUserValidator :AbstractValidator<ApplicationUser>
{
    public ApplicationUserValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("Fornavn skal ikke være tom");
        RuleFor(x => x.Email).NotEmpty().WithMessage("E-Post skal ikke vøre tomt");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("Etternavn skal ikke være tom");
        RuleFor(x => x.Email).EmailAddress().WithMessage("E-Post er ikke gyldig");
        RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefonnummer skal ikke være tom");
        RuleFor(x => x.PhoneNumber).Matches(@"^\d{8}$").WithMessage("Telefonnummer er ikke gyldig");
        
        
        
    }
}