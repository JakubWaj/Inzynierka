using Application.Abstraction;

namespace Application.Features.Movies.Queries.GetPaginatedMovies;

public class GetPaginatedMoviesQuery: IQuery<IEnumerable<MovieDto>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}