using Application.Abstraction;
using Application.Features.Movies;

namespace Application.Features.Country.Queries.GetMoviesFromCountry;

public class GetMoviesFromCountryQueryHandler : IQueryHandler<GetMoviesFromCountryQuery, IEnumerable<MovieDto>>
{
    private readonly ICountryRepository _countryRepository;
    private readonly IMovieRepository _movieRepository;

    public GetMoviesFromCountryQueryHandler(ICountryRepository countryRepository, IMovieRepository movieRepository)
    {
        _countryRepository = countryRepository;
        _movieRepository = movieRepository;
    }
    
    public Task<IEnumerable<MovieDto>> HandleAsync(GetMoviesFromCountryQuery query)
    {
        throw new NotImplementedException();
    }
}