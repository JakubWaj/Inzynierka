namespace Application.Features.MovieCountry;

public class MovieCountryDto
{
    public Guid Id { get; set; }
    public string CountryName { get; set; }
}

public class  CountryMovieDto
{
    public Guid Id { get; set; }
    public string ProductionName { get; set; }
}