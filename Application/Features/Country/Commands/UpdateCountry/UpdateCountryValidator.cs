using FluentValidation;

namespace Application.Features.Country.Commands.UpdateCountry;

public class UpdateCountryValidator : AbstractValidator<UpdateCountryCommand>
{
    public UpdateCountryValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Name is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("Name must not exceed 50 characters.");
    }
}