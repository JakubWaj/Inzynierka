using Application.Abstraction;

namespace Application.Features.Movies.Queries.SearchMoviesByGenres;

public class SearchMoviesByGenresQuery : IQuery<IEnumerable<MovieDto>>
{
    public string Genre { get; set; }
}