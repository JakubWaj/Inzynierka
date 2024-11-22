using Application.Abstraction;
using Domain.Entities;

namespace Application.Features.Movies.Commands.CreateMovie;

public class CreateMovieCommandHandler : ICommandHandler<CreateMovieCommand,bool>
{
    private readonly IMovieRepository _movieRepository;

    public CreateMovieCommandHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    public async Task<bool> HandleAsync(CreateMovieCommand command)
    {
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
        await _movieRepository.AddAsync(movie);
        if (await _movieRepository.ExistsAsync(movie.Id))
        {
            return true;
        }
        return false;
    }
}