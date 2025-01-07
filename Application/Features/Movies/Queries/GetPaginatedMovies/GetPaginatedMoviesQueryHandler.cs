using Application.Abstraction;

namespace Application.Features.Movies.Queries.GetPaginatedMovies;

public class GetPaginatedMoviesQueryHandler : IQueryHandler<GetPaginatedMoviesQuery,IEnumerable<MovieDto>>
{
    private readonly IMovieRepository _repository;

    public GetPaginatedMoviesQueryHandler(IMovieRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<MovieDto>> HandleAsync(GetPaginatedMoviesQuery query)
    {
        var movies = await _repository.GetPaginatedMovies(query.PageNumber, query.PageSize);
        return movies.ToDto();
    }
}