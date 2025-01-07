using Application.Abstraction;

namespace Application.Features.Movies.Commands.AddFewMovies;

public class AddFewMoviesCommandHandler : ICommandHandler<AddFewMoviesCommand,bool>
{
    private readonly IMovieRepository _movieRepository;

    public AddFewMoviesCommandHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    public async Task<bool> HandleAsync(AddFewMoviesCommand command)
    {
        await _movieRepository.AddRangeOfMovies(command.MoviesList);
        return true;
    }
}