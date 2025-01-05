using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Movies.Exceptions;
using Application.Features.Users;

namespace Application.Features.Movies.Commands.AddMovieToWatchList;

public class AddMovieToWatchListCommandHandler : ICommandHandler<AddMovieToWatchListCommand,bool>
{
    private readonly IMovieRepository _movieRepository;
    private readonly IUserRepository _userRepository;
    public AddMovieToWatchListCommandHandler(IMovieRepository movieRepository, IUserRepository userRepository)
    {
        _movieRepository = movieRepository;
        _userRepository = userRepository;
    }
    
    public async Task<bool> HandleAsync(AddMovieToWatchListCommand command)
    {
        var user = await _userRepository.GetAsync(command.UserId);
        var movie = await _movieRepository.GetAsync(command.MovieId);
        if (await _movieRepository.WatchLaterMovieExistsAsync(command.UserId, command.MovieId))
        {
            throw new AlreadyExistsException();
        }
        
        if (user == null || movie == null)
        {
            throw new NotFoundException("User or Movie not found!");
        }
        await _movieRepository.AddWatchLaterMovieAsync(command.UserId, command.MovieId, command.Id);
        return true;
    }
}