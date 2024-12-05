using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Reviews.Exceptions;

namespace Application.Features.Reviews.Commands.DeleteReview;

public class DeleteReviewCommandHandler : ICommandHandler<DeleteReviewCommand, bool>
{
    
    private readonly IReviewRepository _reviewRepository;
    
    public DeleteReviewCommandHandler(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }
    
    public async Task<bool> HandleAsync(DeleteReviewCommand command)
    {
        var review = await _reviewRepository.GetAsync(command.Id);
        if (review == null)
        {
            throw new NotFoundException("Review not found");
        }

        if (review.UserId != command.UserId)
        {
            throw new ForbiddenException("You are not allowed to delete this review");
        }
        
        await _reviewRepository.DeleteAsync(command.Id);
        return true;
        
    }
}