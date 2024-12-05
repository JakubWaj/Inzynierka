using Application.Abstraction;
using Application.Features.Country;
using Domain.Entities;

namespace Application.Features.Movies.Commands.CreateMovie;

public class CreateMovieCommandHandler : ICommandHandler<CreateMovieCommand,bool>
{
    private readonly IMovieRepository _movieRepository;
    private readonly ICountryRepository _countryRepository;

    public CreateMovieCommandHandler(IMovieRepository movieRepository, ICountryRepository countryRepository)
    {
        _movieRepository = movieRepository;
        _countryRepository = countryRepository;
    }
    
    public async Task<bool> HandleAsync(CreateMovieCommand command)
    {
        
        var countries = await _countryRepository.GetCountiesByName(command.Countries);
        //make
        var movieCountry = countries.Select(x => new Domain.Entities.MovieCountry()
        {
            CountryId = x.Id,
            MovieId = command.Id
        });
        
        var movie = new Movie()
        {
            Id = command.Id,
            Title = command.Title,
            Description = command.Description,
            Genre = command.Genre,
            ReleaseDate = command.ReleaseDate,
            BoxOffice = command.BoxOffice,
            Duration = command.Duration,
            CountryOfMovie = movieCountry.ToList()
        };
        
        await _movieRepository.AddAsync(movie);
        if (await _movieRepository.ExistsAsync(movie.Id))
        {
            return true;
        }
        return false;
    }
}