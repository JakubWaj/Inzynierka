using Application.Abstraction;

namespace Application.Features.Movies.Queries.SearchMovieByYear;

public class SearchMovieByYearQuery : IQuery<IEnumerable<MovieDto>>
{
    public int Year { get; set; }
}