using Application.Abstraction;

namespace Application.Features.Reviews.Queries.GetReviews;

public class GetReviewsQueryHandler : IQueryHandler<GetReviewsQuery,IEnumerable<ReviewDto>>
{
    private readonly IReviewRepository _reviewRepository;

    public GetReviewsQueryHandler(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }
    
    public async Task<IEnumerable<ReviewDto>> HandleAsync(GetReviewsQuery query)
    {
       var reviews = await _reviewRepository.GetAllAsync();
       return reviews.ToDto();
    }
}