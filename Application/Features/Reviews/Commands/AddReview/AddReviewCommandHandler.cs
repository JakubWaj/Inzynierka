using Application.Abstraction;
using Domain.Entities;

namespace Application.Features.Reviews.Commands.AddReview;

public class AddReviewCommandHandler : ICommandHandler<AddReviewCommand, bool>
{
    private readonly IReviewRepository _reviewRepository;

    public AddReviewCommandHandler(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }
    
    public async Task<bool> HandleAsync(AddReviewCommand command)
    {
        //dodac sprawdzenie ze user juz zrobil review filmu
        var reviewExists = await _reviewRepository.ExistsAsync(command.MovieId, command.UserId);
        if (reviewExists)
        {
            throw new Exception("User already reviewed this movie");
        }
        
        var review = new Review
        {
            Id = command.Id,
            Comment = command.Comment,
            Rating = command.Rating,
            MovieId = command.MovieId,
            UserId = command.UserId
        };
        
        await _reviewRepository.AddAsync(review);
        return true;
    }
}