namespace Application.Features.Movies.Queries.GetAllMovies;

public class GetAllMoviesQueryHandler : Abstraction.IQueryHandler<GetAllMoviesQuery,IEnumerable<MovieDto>>
{
    private readonly IMovieRepository _repository;

    public GetAllMoviesQueryHandler(IMovieRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<MovieDto>> HandleAsync(GetAllMoviesQuery query)
    {
        var movies = await _repository.GetAllAsync();
        return movies.ToDto();
    }
}   