using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.Users;

namespace Application.Features.Movies.Queries.GetUsersFavoriteMovies;

public class GetUsersFavoriteMoviesQueryHandler : IQueryHandler<GetUsersFavoriteMoviesQuery, IEnumerable<MovieDto>>
{
    private readonly IMovieRepository _movieRepository;
    private readonly IUserRepository _userRepository;
    public GetUsersFavoriteMoviesQueryHandler(IUserRepository userRepository, IMovieRepository movieRepository)
    {
        _userRepository = userRepository;
        _movieRepository = movieRepository;
    }
    
    public async Task<IEnumerable<MovieDto>> HandleAsync(GetUsersFavoriteMoviesQuery query)
    {
        var user = await _userRepository.GetAsync(query.UserId);
        if (user == null)
        {
            throw new NotFoundException("User not found!");
        }
        var FavoriteMovies = await _movieRepository.GetFavoriteMoviesAsync(query.UserId);
        return FavoriteMovies.ToDto();
    }
}