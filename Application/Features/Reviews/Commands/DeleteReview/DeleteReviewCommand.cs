using Application.Abstraction;

namespace Application.Features.Reviews.Commands.DeleteReview;

public class DeleteReviewCommand : ICommand<bool>
{
    public Guid Id { get; set; }
}