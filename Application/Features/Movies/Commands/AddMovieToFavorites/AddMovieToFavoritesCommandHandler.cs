using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Users;

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
        if (user == null || movie == null)
        {
            throw new NotFoundException("User or Movie not found!");
        }
        await _movieRepository.AddFavoriteMovieAsync(command.UserId, command.MovieId, command.Id);
        return true;
    }
}