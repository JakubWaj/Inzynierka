using Application.Shared;

namespace Application.Features.Movies.Queries;

public class GetMovieQueryHandler : Abstraction.IQueryHandler<GetMovieQuery,MovieDto>
{
    private readonly IMovieRepository _repository;

    public GetMovieQueryHandler(IMovieRepository repository)
    {
        _repository = repository;
    }
    public async Task<MovieDto> HandleAsync(GetMovieQuery query)
    {
        var movie = await _repository.GetAsync(query.Id);
        return new MovieDto(movie.Id,movie.Title);
    }
}