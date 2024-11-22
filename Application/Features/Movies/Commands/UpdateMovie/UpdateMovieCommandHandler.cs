using Application.Abstraction;
using Application.Features.Exceptions;
using Domain.Entities;

namespace Application.Features.Movies.Commands.UpdateMovie;

public class UpdateMovieCommandHandler : ICommandHandler<UpdateMovieCommand, bool>
{
    private readonly IMovieRepository _movieRepository;

    public UpdateMovieCommandHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    public async Task<bool> HandleAsync(UpdateMovieCommand command)
    {
        var existingMovie = await _movieRepository.ExistsAsync(command.Id);
        if (existingMovie == false)
        {
            throw new NotFoundException("Movie");
        }
        
        var movie = new Movie()
        {
            Id = command.Id,
            Title = command.Title,
            Description = command.Description,
            Genre = command.Genre,
            ReleaseDate = command.ReleaseDate,
            BoxOffice = command.BoxOffice,
            Duration = command.Duration
        };
        
        await _movieRepository.UpdateAsync(movie);
        return true;
    }
}