using FluentValidation;

namespace Application.Features.Roles.Commands.UpdateRole;

public class UpdateRoleValidator : AbstractValidator<UpdateRoleCommand>
{
    public UpdateRoleValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id is required.");
        RuleFor(x => x.PersonId)
            .NotEmpty().WithMessage("PersonId is required.");
        RuleFor(x => x.MovieId)
            .NotEmpty().WithMessage("MovieId is required.");
        RuleFor(x => x.MovieProductionRole)
            .NotEmpty().WithMessage("MovieProductionRole is required.");
        RuleFor(x => x.Character)
            .MaximumLength(100).WithMessage("Character must not exceed 100 characters.");        
    }
}