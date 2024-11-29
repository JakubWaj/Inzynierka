using Application.Abstraction;
using Application.Features.Exceptions;

namespace Application.Features.Reviews.Queries.GetReview;

public class GetReviewQueryHandler : IQueryHandler<GetReviewQuery, ReviewDto>
{
    private readonly IReviewRepository _reviewRepository;

    public GetReviewQueryHandler(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }
    
    public async Task<ReviewDto> HandleAsync(GetReviewQuery query)
    {
        var exists = await _reviewRepository.ExistsAsync(query.Id);
        if (!exists)
        {
            throw new NotFoundException("Review not found");
        }
        var review = await _reviewRepository.GetAsync(query.Id);
        return review.ToDto();
    }
}