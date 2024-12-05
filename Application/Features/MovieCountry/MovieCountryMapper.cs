namespace Application.Features.MovieCountry;

public static class MovieCountryMapper
{
    public static MovieCountryDto CountriesToDto(this Domain.Entities.MovieCountry movieCountry)
    {
        return new MovieCountryDto()
        {
            Id = movieCountry.CountryId,
            CountryName = movieCountry.Country.Name
        };
    }
    
    public static IEnumerable<MovieCountryDto> CountriesToDto(this IEnumerable<Domain.Entities.MovieCountry> movieCountries)
    {
        return movieCountries.Select(x => x.CountriesToDto());
    }
    
    public static CountryMovieDto MoviesToDto(this Domain.Entities.MovieCountry movieCountry)
    {
        return new CountryMovieDto()
        {
            Id = movieCountry.MovieId,
            ProductionName = movieCountry.Movie.Title
        };
    }
    
    public static IEnumerable<CountryMovieDto> MoviesToDto(this IEnumerable<Domain.Entities.MovieCountry> movieCountries)
    {
        return movieCountries.Select(x => x.MoviesToDto());
    }
    
}