using Application.Abstraction;

namespace Application.Features.Reviews.Queries.GetReview;

public class GetReviewQuery : IQuery<ReviewDto>
{
    public Guid Id { get; set; }
}