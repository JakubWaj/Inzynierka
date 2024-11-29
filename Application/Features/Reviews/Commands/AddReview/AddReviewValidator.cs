using FluentValidation;

namespace Application.Features.Reviews.Commands.AddReview;

public class AddReviewValidator : AbstractValidator<AddReviewCommand>
{
    public AddReviewValidator()
    {
        RuleFor(x => x.Comment)
            .NotEmpty().WithMessage("Comment is required.")
            .MaximumLength(500).WithMessage("Comment must not exceed 500 characters.");
        RuleFor(x => x.Rating)
            .InclusiveBetween(1, 5).WithMessage("Rating must be between 1 and 5.");
        RuleFor(x => x.MovieId)
            .NotEmpty().WithMessage("MovieId is required.");
        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("UserId is required.");
    }   
}