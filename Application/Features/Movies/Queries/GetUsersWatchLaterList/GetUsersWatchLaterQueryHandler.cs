using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Users;

namespace Application.Features.Movies.Queries.GetUsersWatchLaterList;

public class GetUsersWatchLaterQueryHandler : IQueryHandler<GetUsersWatchLaterListQuery, IEnumerable<MovieDto>>
{
    
    private readonly IMovieRepository _movieRepository;
    private readonly IUserRepository _userRepository;

    public GetUsersWatchLaterQueryHandler(IUserRepository userRepository, IMovieRepository movieRepository)
    {
        _userRepository = userRepository;
        _movieRepository = movieRepository;
    }
    
    public async Task<IEnumerable<MovieDto>> HandleAsync(GetUsersWatchLaterListQuery query)
    {
        var user = await _userRepository.GetAsync(query.UserId);

        if (user == null)
        {
            throw new NotFoundException("User not found!");
        }
        
        var WatchLaterMovies = await _movieRepository.GetWatchLaterMoviesAsync(query.UserId);
        return WatchLaterMovies.ToDto();
    }
}