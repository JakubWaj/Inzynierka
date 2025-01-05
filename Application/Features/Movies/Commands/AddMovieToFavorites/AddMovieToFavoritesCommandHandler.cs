using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Movies.Exceptions;
using Application.Features.Users;
using Application.Features.Users.Exceptions;

namespace Application.Features.Movies.Commands.AddMovieToFavorites;

public class AddMovieToFavoritesCommandHandler : ICommandHandler<AddMovieToFavoritesCommand,bool>
{
    private readonly IMovieRepository _movieRepository;
    private readonly IUserRepository _userRepository;

    public AddMovieToFavoritesCommandHandler(IMovieRepository movieRepository, IUserRepository userRepository)
    {
        _movieRepository = movieRepository;
        _userRepository = userRepository;
    }
    
    public async Task<bool> HandleAsync(AddMovieToFavoritesCommand command)
    {
        var user = await _userRepository.GetAsync(command.UserId);
        var movie = await _movieRepository.GetAsync(command.MovieId);
        
        if (await _movieRepository.FavMovieExistsAsync(command.UserId, command.MovieId))
        {
            throw new AlreadyExistsException();
        }
        
        if (await _userRepository.ExistsAsync(command.UserId) == false)
        {
            throw new NotFoundException("User not found");
        }
        if (await _movieRepository.ExistsAsync(command.MovieId) == false)
        {
            throw new NotFoundException("Movie not found");
        }
        await _movieRepository.AddFavoriteMovieAsync(command.UserId, command.MovieId, command.Id);
        return true;
    }
}