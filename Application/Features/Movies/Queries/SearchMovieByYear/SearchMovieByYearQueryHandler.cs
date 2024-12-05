using Application.Abstraction;

namespace Application.Features.Movies.Queries.SearchMovieByYear;

public class SearchMovieByYearQueryHandler : IQueryHandler<SearchMovieByYearQuery,IEnumerable<MovieDto>>
{
    private readonly IMovieRepository _movieRepository;

    public SearchMovieByYearQueryHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    public async Task<IEnumerable<MovieDto>> HandleAsync(SearchMovieByYearQuery query)
    {
        var movies =  await _movieRepository.GetByReleaseYearAsync(query.Year);
        return movies.ToDto();
    }
}