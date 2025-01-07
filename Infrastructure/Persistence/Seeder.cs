using Application.Features.Country;
using Application.Features.Movies;
using Domain.Common.Enums;
using Domain.Entities;
using Newtonsoft.Json;

namespace Infrastructure.Persistence;

public class Seeder : ISeeder
{
    private readonly MoviesDbContext _context;
    private readonly ICountryRepository _countryRepository;

    public Seeder(MoviesDbContext context,ICountryRepository countryRepository)
    {
        _context = context;
        _countryRepository = countryRepository;
    }
    
    public async Task Seed()
    {
        
        string jsonCountry = System.IO.File.ReadAllText("countries.json");
        List<Country> countriess = JsonConvert.DeserializeObject<List<Country>>(jsonCountry);
        foreach (var country in countriess)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(country.Name);
            Console.WriteLine("-------------------");
            await _context.Countries.AddAsync(country);
        }
        await _context.SaveChangesAsync();
        string json = System.IO.File.ReadAllText("moviesMind.json");
        var settings = new JsonSerializerSettings();
        settings.Converters.Add(new GenreEnumConverter());
        List<MovieInternal> moviesMind =
            JsonConvert.DeserializeObject<List<MovieInternal>>(json, settings);
        foreach (var film in moviesMind)
        {
            var countries = await _countryRepository.GetCountiesByName(film.CountryOfMovie.ToArray());
            //make
            var movieCountry = countries.Select(x => new Domain.Entities.MovieCountry()
            {
                CountryId = x.Id,
                MovieId = film.Id
            });
            var movie = new Movie()
            {
                Id = film.Id,
                Title = film.Title,
                Description = film.Description,
                Genre = film.Genre,
                ReleaseDate = film.ReleaseDate,
                CountryOfMovie = movieCountry.ToList(),
                BoxOffice = film.BoxOffice,
                Duration = film.Duration,
                Image = film.Image !=null? $"https://image.tmdb.org/t/p/w500{film.Image}" : null,
                Tmdb_Id = film.Tmdb_Id,
                Popularity = film.Popularity
            };
            Console.WriteLine($"Id{film.Id} Movie {film.Title} added");
            
            await _context.Movies.AddAsync(movie);
        }
        await _context.SaveChangesAsync();
    }
    
    public class MovieInternal
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<string> CountryOfMovie { get; set; }
        public int BoxOffice { get; set; }
        public int Duration { get; set; }
        public string? Image { get; set; }
        public int Tmdb_Id { get; set; }
        public decimal Popularity { get; set; }
    }
}

public interface ISeeder
{
    Task Seed();
}