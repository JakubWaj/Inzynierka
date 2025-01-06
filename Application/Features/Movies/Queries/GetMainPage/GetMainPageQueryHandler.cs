using Application.Abstraction;
using Application.Features.Reviews;
using Application.Features.Users;

namespace Application.Features.Movies.Queries.GetMainPage;

public class GetMainPageQueryHandler : IQueryHandler<GetMainPageQuery,IEnumerable<MainPageMovieDto>>
{
    private readonly IMovieRepository _repository;
    private readonly IReviewRepository _reviewRepository;
    private readonly IUserRepository _userRepository;

    public GetMainPageQueryHandler(IMovieRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<MainPageMovieDto>> HandleAsync(GetMainPageQuery query)
    {
        var movies = await _repository.GetAllAsync();
        var userId = query.UserId;
        var likedMovies = await _repository.GetFavoriteMoviesAsync(userId);
        var watchLaterMovies = await _repository.GetWatchLaterMoviesAsync(userId);
        var result = movies.Select(x => x.ToMainPageDto(true,true));
        return result;
    }
}