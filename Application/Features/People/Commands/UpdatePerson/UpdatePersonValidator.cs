﻿using FluentValidation;

namespace Application.Features.People.Commands.UpdatePerson;

public class UpdatePersonValidator : AbstractValidator<UpdatePersonCommand>
{
    public UpdatePersonValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("First name is required")
            .MaximumLength(100).WithMessage("First name must not exceed 100 characters");
        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Last name is required")
            .MaximumLength(100)
            .WithMessage("Last name must not exceed 100 characters");
        RuleFor(x => x.BirthDate)
            .GreaterThan(new DateTime(1900, 1, 1)).WithMessage("Birth date must be after 1900-01-01");
        RuleFor(x => x.Biography)
            .MaximumLength(500).WithMessage("Biography must not exceed 500 characters");
    }
}