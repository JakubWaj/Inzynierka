using Application.Features.Movies;

namespace Application.Features;

public static class MovieMapper
{
    public static MovieDto ToDto(this Domain.Entities.Movie movie)
    {
        return new MovieDto(movie.Id, movie.Title);
    }
    
    public static IEnumerable<MovieDto> ToDto(this IEnumerable<Domain.Entities.Movie> movies)
    {
        return movies.Select(x => x.ToDto());
    }
}
