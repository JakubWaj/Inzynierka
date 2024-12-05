using Application.Abstraction;

namespace Application.Features.Movies.Queries.SearchMoviesByGenres;

public class SearchMoviesByGenresQueryHandler : IQueryHandler<SearchMoviesByGenresQuery,IEnumerable<MovieDto>>
{
    private readonly IMovieRepository _movieRepository;

    public SearchMoviesByGenresQueryHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    public async Task<IEnumerable<MovieDto>> HandleAsync(SearchMoviesByGenresQuery query)
    {
        var movies = await _movieRepository.GetByGenreAsync(query.Genre);
        return movies.ToDto();

    }
}