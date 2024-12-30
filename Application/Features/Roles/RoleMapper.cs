using Application.Features.People;
using Application.Features.Reviews;
using Domain.Entities;

namespace Application.Features.Roles;

public static class RoleMapper
{
    public static RoleDto ToDto(this Role review)
    {
        return new RoleDto()
        {
            Id = review.Id,
            PersonId = review.PersonId,
            MovieId = review.MovieId,
            MovieProductionRole = review.MovieProductionRole,
            Character = review.Character,
            Score = (review.Reviews.Count>0? review.Reviews.Average(x => x.Rating):0),
            NumberOfReviews = review.Reviews.Count,
            Movie = review.Movie.ToDto(),
        };
    }
    
    public static RoleMovieDto ToDto(this Movie movie)
    {
        return new RoleMovieDto(movie.Id,movie.Title,movie.Description,movie.Genre,movie.ReleaseDate,movie.BoxOffice,movie.Duration);
    }
    public static IEnumerable<RoleDto> ToDto(this IEnumerable<Role> roles)
    {
        return roles.Select(x => x.ToDto());
    }
}