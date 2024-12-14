using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Users;

namespace Application.Features.Movies.Commands.DeleteMovieFromFavorites;

public class DeleteMovieFromFavoritesCommandHandler : ICommandHandler<DeleteMovieFromFavoritesCommand,bool>
{
    private readonly IMovieRepository _movieRepository;
    private readonly IUserRepository _userRepository;
    public DeleteMovieFromFavoritesCommandHandler(IUserRepository userRepository, IMovieRepository movieRepository)
    {
        _userRepository = userRepository;
        _movieRepository = movieRepository;
    }
    
    public async Task<bool> HandleAsync(DeleteMovieFromFavoritesCommand command)
    {
        var user = await _userRepository.GetAsync(command.UserId);
        var FavoriteMovie = await _movieRepository.GetWatchLaterMoviesAsync(command.UserId);
        var contains = FavoriteMovie.FirstOrDefault(x=>x.Id== command.Id);
        if (contains == null)
        {
            throw new NotFoundException("Movie not found in the favorites list!");
        }
        await _movieRepository.RemoveFavoriteMovieAsync(command.UserId, command.Id);
        return true;
    }
}