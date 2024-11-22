using Application.Abstraction;
using Application.Features.Exceptions;

namespace Application.Features.Movies.Commands.DeleteMovie;

public class DeleteMovieCommandHandler : ICommandHandler<DeleteMovieCommand,bool>
{

    public readonly IMovieRepository _movieRepository;
    public DeleteMovieCommandHandler(IMovieRepository movieRepository)
    {
        IMovieRepository _movieRepository;
    }
    
    public async Task<bool> HandleAsync(DeleteMovieCommand command)
    {
        var existingMovie = await _movieRepository.ExistsAsync(command.Id);
        if (!existingMovie) throw new NotFoundException("Movie");
        await _movieRepository.DeleteAsync(command.Id);
        return true;       
    }
}