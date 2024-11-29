using Application.Features.Exceptions;

namespace Application.Features.Movies.Queries.GetMovie;

public class GetMovieQueryHandler : Abstraction.IQueryHandler<GetMovieQuery,MovieDto>
{
    private readonly IMovieRepository _repository;

    public GetMovieQueryHandler(IMovieRepository repository)
    {
        _repository = repository;
    }
    public async Task<MovieDto> HandleAsync(GetMovieQuery query)
    {
        if(!(await _repository.ExistsAsync(query.Id)))
        {
            throw new NotFoundException(query.Id.ToString());
        }
        var movie = await _repository.GetAsync(query.Id);
        return new MovieDto(movie.Id,movie.Title , movie.Description, movie.Genre, movie.ReleaseDate, movie.BoxOffice, movie.Duration);
    }
}