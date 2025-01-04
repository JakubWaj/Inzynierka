using Application.Features.Users;
using Domain.Entities;

namespace Application.Features.Reviews;

public static class ReviewMapper 
{
    public static ReviewDto ToDto(this Review review)
    {
        return new ReviewDto
        {
            Id = review.Id,
            Comment = review.Comment,
            Rating = review.Rating,
            MovieId = review.MovieId,
            UserId = review.UserId,
            Movie = review.Movie.ToDtoModel(),
            User = review.User.MapToUserDto()
        };
    }
    public static IEnumerable<ReviewDto> ToDto(this IEnumerable<Review> reviewDto)
    {
        return reviewDto.Select(x => x.ToDto());
    }
}