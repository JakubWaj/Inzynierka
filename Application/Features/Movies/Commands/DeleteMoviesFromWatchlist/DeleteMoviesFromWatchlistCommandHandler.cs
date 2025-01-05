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
        if (await _movieRepository.WatchLaterMovieExistsAsync(command.UserId,command.Id)==false)
        {
            throw new NotFoundException("Movie not found in the favorites list!");
        }
        await _movieRepository.RemoveWatchLaterMovieAsync(command.UserId, command.Id);
        return true;
    }
}