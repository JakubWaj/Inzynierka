using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Movies;

namespace Application.Features.Users.Queries.GetUsersActivity;

public class GetUsersActivityQueryHandler : IQueryHandler<GetUsersActivityQuery, ActivityDTO>
{
    private readonly IUserRepository _userRepository;
    private readonly IMovieRepository _movieRepository;

    public GetUsersActivityQueryHandler(IUserRepository userRepository, IMovieRepository movieRepository)
    {
        _userRepository = userRepository;
        _movieRepository = movieRepository;
    }
    
    public async Task<ActivityDTO> HandleAsync(GetUsersActivityQuery query)
    {
        var user = await _userRepository.GetAsync(query.UserId);
        if (user == null)
        {
            throw new NotFoundException("User not found");
        }
        var favoriteMovies = await _movieRepository.GetFavoriteMoviesAsync(query.UserId);
        var watchedMovies = await _movieRepository.GetUsersWatchedMoviesync(query.UserId);
        var watchLaterMovies = await _movieRepository.GetWatchLaterMoviesAsync(query.UserId);
        return new ActivityDTO(user.Id, user.Id,user.Login, favoriteMovies.ToDto(), watchedMovies.ToDto(), watchLaterMovies.ToDto());
    }
}