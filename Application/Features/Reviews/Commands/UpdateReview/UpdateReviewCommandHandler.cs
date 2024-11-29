using Application.Abstraction;
using Application.Features.Exceptions;
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
        var review = new Review()
        {
            Id = command.Id,
            Comment = command.Comment,
            Rating = command.Rating,
            MovieId = command.MovieId,
            UserId = command.UserId
        };
        await _reviewRepository.UpdateAsync(review);
        return true;
    }
    
}