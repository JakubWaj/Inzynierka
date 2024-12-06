using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Reviews.Exceptions;
using Domain.Entities;

namespace Application.Features.Reviews.Commands.UpdateReview;

public class UpdateReviewCommandHandler : ICommandHandler<UpdateReviewCommand,bool>
{
    private readonly IReviewRepository _reviewRepository;
    public UpdateReviewCommandHandler(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }
    public async Task<bool> HandleAsync(UpdateReviewCommand command)
    {
        var exists = await _reviewRepository.ExistsAsync(command.Id);
        if (!exists)
        {
            throw new NotFoundException("Review not found");
        }
        var oldReview = await _reviewRepository.GetAsync(command.Id);
        if (oldReview.UserId != command.UserId)
        {
            throw new ForbiddenException("You are not allowed to update this review");
        }
        oldReview.Comment = command.Comment;
        oldReview.Rating = command.Rating;
        await _reviewRepository.UpdateAsync(oldReview);
        return true;
    }
    
}