using Application.Abstraction;
using Domain.Entities;
using FluentValidation;

namespace Application.Features.Roles.Commands.AddRole;

public class AddRoleValidator : AbstractValidator<AddRoleCommand>
{
    public AddRoleValidator()
    {
        RuleFor(x => x.PersonId)
            .NotEmpty().WithMessage("PersonId is required.");
        RuleFor(x => x.MovieId)
            .NotEmpty().WithMessage("MovieId is required.");
        RuleFor(x => x.Character)
            .MaximumLength(100).WithMessage("Character must not exceed 100 characters.");
    }
}