using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Movies.Commands.DeleteMovieFromFavorites;
using Application.Features.Users;

namespace Application.Features.Movies.Commands.DeleteMoviesFromWatchlist;

public class DeleteMoviesFromWatchlistCommandHandler : ICommandHandler<DeleteMoviesFromWatchlistCommand,bool>
{
    private readonly IMovieRepository _movieRepository;
    private readonly IUserRepository _userRepository;
    public DeleteMoviesFromWatchlistCommandHandler(IUserRepository userRepository, IMovieRepository movieRepository)
    {
        _userRepository = userRepository;
        _movieRepository = movieRepository;
    }
    
    public async Task<bool> HandleAsync(DeleteMoviesFromWatchlistCommand command)
    {
        var user = await _userRepository.GetAsync(command.UserId);
        var WatchLater = await _movieRepository.GetWatchLaterMoviesAsync(command.UserId);
        var contains = WatchLater.FirstOrDefault(x=>x.Id== command.Id);
        if (contains == null)
        {
            throw new NotFoundException("Movie not found in the watch later list!");
        }
        await _movieRepository.RemoveWatchLaterMovieAsync(command.UserId, command.Id);
        return true;
    }
}