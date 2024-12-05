using Application.Abstraction;

namespace Application.Features.Movies.Queries.SearchMovieByTitle;

public class SearchMovieByTitleQuery : IQuery<IEnumerable<MovieDto>>
{
    public string Title { get; set; }
}