using Application.Abstraction;

namespace Application.Features.Movies.Queries.SearchMovieByTitle;

public class SearchMovieByTitleQueryHandler : IQueryHandler<SearchMovieByTitleQuery,IEnumerable<MovieDto>>
{
    private readonly IMovieRepository _movieRepository;

    public SearchMovieByTitleQueryHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    public async Task<IEnumerable<MovieDto>> HandleAsync(SearchMovieByTitleQuery query)
    {
        var movies =  await _movieRepository.GetByTitleAsync(query.Title);
        return movies.ToDto();
    }
}