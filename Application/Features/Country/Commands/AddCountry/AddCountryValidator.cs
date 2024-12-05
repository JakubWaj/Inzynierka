using FluentValidation;

namespace Application.Features.Country.Commands.AddCountry;

public class AddCountryValidator : AbstractValidator<AddCountryCommand>
{
    public AddCountryValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Name is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("Name must not exceed 50 characters.");
    }
}