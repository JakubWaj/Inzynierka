using Application.Abstraction;

namespace Application.Features.Movies.Commands.CreateMovie;

public class CreateMovieCommandHandler : ICommandHandler<CreateMovieCommand,bool>
{
    private readonly IMovieRepository _movieRepository;

    public CreateMovieCommandHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    public Task<bool> HandleAsync(CreateMovieCommand command)
    {
        throw new NotImplementedException();
    }
}