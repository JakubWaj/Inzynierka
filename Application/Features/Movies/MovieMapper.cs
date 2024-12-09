using Application.Features.MovieCountry;
using Application.Features.Movies;

namespace Application.Features;

public static class MovieMapper
{
    public static MovieDto ToDto(this Domain.Entities.Movie movie,decimal? score=default,int? numberOfReviews=default)
    {
        return new MovieDto(movie.Id, movie.Title , movie.Description, movie.Genre, movie.ReleaseDate, movie.BoxOffice, movie.Duration, movie.CountryOfMovie.CountriesToDto(),score,numberOfReviews);
    }
    
    public static IEnumerable<MovieDto> ToDto(this IEnumerable<Domain.Entities.Movie> movies)
    {
        return movies.Select(x => x.ToDto());
    }
}
