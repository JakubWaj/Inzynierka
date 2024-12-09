using API.Controllers;
using Application.Abstraction;
using Application.Features.Movies.Commands.CreateMovie;
using Application.Features.Movies.Commands.DeleteMovie;
using Application.Features.Movies.Commands.UpdateMovie;
using Application.Features.Movies.Queries.GetAllMovies;
using Application.Features.Movies.Queries.GetMovie;
using Application.Features.Movies.Queries.GetMovieByCountry;
using Application.Features.Movies.Queries.SearchMovieByTitle;
using Application.Features.Movies.Queries.SearchMovieByYear;
using Application.Features.Movies.Queries.SearchMoviesByGenres;
using Microsoft.AspNetCore.Mvc;

namespace API.Features.Movie;

public class MovieController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;

    public MovieController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
    {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetMovieAsync(Guid id)
    {
        var movie = new GetMovieQuery(id);
        var result = await _queryDispatcher.SendAsync(movie);
        return Ok(result);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetMoviesAsync()
    {
        var movies = new GetAllMoviesQuery();
        var result = await _queryDispatcher.SendAsync(movies);
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateMovieAsync(MovieRequest movieRequest)
    {
        var id = Guid.NewGuid();
        
        var command = new CreateMovieCommand
        {
            Id = id,
            Title = movieRequest.Title,
            Description = movieRequest.Description,
            Genre = movieRequest.Genre,
            ReleaseDate = movieRequest.ReleaseDate,
            BoxOffice = movieRequest.BoxOffice,
            Duration = movieRequest.Duration,
            Countries = movieRequest.Countries
        };
        
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(new
        {
            Id= id,
            Result= result
        });
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMovieAsync(Guid id)
    {
        var command = new DeleteMovieCommand { Id = id };
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(result);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateMovieAsync(Guid id, UpdateMovieCommand command)
    {
        command.Id = id;
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(result);
    }
    
    [HttpGet("title/{title}")]
    public async Task<IActionResult> SearchMoviesAsync(string title)
    {
        var query = new SearchMovieByTitleQuery(){Title = title};
        var result = await _queryDispatcher.SendAsync(query);
        return Ok(result); 
    }
    
    [HttpGet("genre/{genre}")]
    public async Task<IActionResult> SearchMoviesByGenreAsync(string genre)
    {
        
        var query = new SearchMoviesByGenresQuery(){Genre = genre};
        var result = await _queryDispatcher.SendAsync(query);
        return Ok(result);
    }
    
    [HttpGet("releaseYear/{releaseYear}")]
    public async Task<IActionResult> SearchMoviesByReleaseYearAsync(int releaseYear)
    {
        
        var query = new SearchMovieByYearQuery(){Year = releaseYear};
        var result = await _queryDispatcher.SendAsync(query);
        return Ok(result);
    }
    
    [HttpGet("country/{countryId}")]
    public async Task<IActionResult> SearchMoviesByCountryAsync(Guid countryId)
    {
        
        var query = new GetMovieByCountryQuery(){ CountryId = countryId};
        var result = await _queryDispatcher.SendAsync(query);
        return Ok(result);
    }
    
    
    
}