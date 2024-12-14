using Application.Abstraction;

namespace Application.Features.Movies.Queries.GetUsersFavoriteMovies;

public class GetUsersFavoriteMoviesQuery : IQuery<IEnumerable<MovieDto>>
{
    public Guid UserId { get; set; }
}