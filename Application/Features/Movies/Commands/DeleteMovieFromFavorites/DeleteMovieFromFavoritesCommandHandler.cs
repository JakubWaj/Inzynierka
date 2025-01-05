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
        if (await _movieRepository.FavMovieExistsAsync(command.UserId,command.Id)==false)
        {
            throw new NotFoundException("Movie not found in the favorites list!");
        }
        await _movieRepository.RemoveFavoriteMovieAsync(command.UserId, command.Id);
        return true;
    }
}