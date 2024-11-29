using Application.Abstraction;

namespace Application.Features.Reviews.Commands.AddReview;

public class AddReviewCommand : ICommand<bool>
{
    public Guid Id { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }
    public Guid MovieId { get; set; }
    public Guid UserId { get; set; }
}