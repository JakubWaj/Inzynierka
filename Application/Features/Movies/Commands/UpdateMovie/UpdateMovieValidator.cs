using FluentValidation;

namespace Application.Features.Movies.Commands.UpdateMovie;

public class UpdateMovieValidator: AbstractValidator<UpdateMovieCommand>
{

    public UpdateMovieValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required")
            .MaximumLength(100).WithMessage("Title must not exceed 100 characters");
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required")
            .MaximumLength(500).WithMessage("Description must not exceed 500 characters");
        RuleFor(x => x.Genre)
            .NotEmpty().WithMessage("Genre is required");
        RuleFor(x => x.ReleaseDate)
            .NotEmpty().WithMessage("Release date is required");
        RuleFor(x => x.BoxOffice)
            .NotEmpty().WithMessage("Box office is required")
            .GreaterThan(0).WithMessage("Box office must be greater than 0");
        RuleFor(x => x.Duration)
            .NotEmpty().WithMessage("Duration is required")
            .GreaterThan(0).WithMessage("Duration must be greater than 0");
    }
}