using API.Controllers;
using Application.Abstraction;
using Application.Features.Movies;
using Application.Features.Movies.Commands.AddFewMovies;
using Application.Features.Movies.Commands.AddMovieToFavorites;
using Application.Features.Movies.Commands.AddMovieToWatchList;
using Application.Features.Movies.Commands.CreateMovie;
using Application.Features.Movies.Commands.DeleteMovie;
using Application.Features.Movies.Commands.DeleteMovieFromFavorites;
using Application.Features.Movies.Commands.DeleteMoviesFromWatchlist;
using Application.Features.Movies.Commands.UpdateMovie;
using Application.Features.Movies.Queries.GetAllMovies;
using Application.Features.Movies.Queries.GetMainPage;
using Application.Features.Movies.Queries.GetMovie;
using Application.Features.Movies.Queries.GetMovieByCountry;
using Application.Features.Movies.Queries.GetUsersFavoriteMovies;
using Application.Features.Movies.Queries.GetUsersWatchLaterList;
using Application.Features.Movies.Queries.SearchMovieByTitle;
using Application.Features.Movies.Queries.SearchMovieByYear;
using Application.Features.Movies.Queries.SearchMoviesByGenres;
using Infrastructure;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Features.Movie;

public class MovieController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;
    private readonly ISeeder _context;

    public MovieController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher,ISeeder _context)
    {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
        this._context = _context;
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
    
    [HttpGet("favorite")]
    [Authorize]
    public async Task<IActionResult> GetFavoriteMoviesAsync()
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var id = Guid.Parse(User.Identity?.Name);
        var query = new GetUsersFavoriteMoviesQuery(){ UserId = id};;
        var result = await _queryDispatcher.SendAsync(query);
        return Ok(result);
    }
    
    [HttpGet("watchLater")]
    [Authorize]
    public async Task<IActionResult> GetWatchLaterMoviesAsync()
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var id = Guid.Parse(User.Identity?.Name);
        var query = new GetUsersWatchLaterListQuery(){ UserId = id};;
        var result = await _queryDispatcher.SendAsync(query);
        return Ok(result);
    }
    
    [HttpPost("watchLater/{movieId}")]
    [Authorize]
    public async Task<IActionResult> AddMovieToWatchLaterAsync(Guid movieId)
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var id = Guid.Parse(User.Identity?.Name);
        var guid = Guid.NewGuid();
        var command = new AddMovieToWatchListCommand()
        {
            UserId = id,
            MovieId = movieId,
            Id = guid
        };
        
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(new
        {
            Result = result,
            Id = guid
        });
    }
    
    [HttpDelete("watchLater/{movieId}")]
    [Authorize]
    public async Task<IActionResult> DeleteMovieFromWatchLaterAsync(Guid movieId)
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        var id = Guid.Parse(User.Identity?.Name);
        var command = new DeleteMoviesFromWatchlistCommand()
        {
            UserId = id,
            Id = movieId
        };
        await _commandDispatcher.SendAsync(command);
        return Accepted();
    }
    
    [HttpPost("favorite/{movieId}")]
    [Authorize]
    public async Task<IActionResult> AddMovieToFavoriteAsync(Guid movieId)
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        
        var id = Guid.Parse(User.Identity?.Name);
        var guid = Guid.NewGuid();
        var command = new AddMovieToFavoritesCommand()
        {
            UserId = id,
            MovieId = movieId,
            Id = guid
        };
        
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(new
        {
            Result = result,
            Id = guid
        });
    }
    
    [HttpDelete("favorite/{movieId}")]
    [Authorize]
    public async Task<IActionResult> DeleteMovieFromFavoriteAsync(Guid movieId)
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        var id = Guid.Parse(User.Identity?.Name);
        var command = new DeleteMovieFromFavoritesCommand()
        {
            UserId = id,
            Id = movieId
        };
        await _commandDispatcher.SendAsync(command);
        return Accepted();
    }
    
    [HttpGet("mainpage")]
    [Authorize]
    public async Task<IActionResult> GetMainPageMoviesAsync()
    {
        if(User.Identity?.Name is null)
        {
            return NotFound();
        }
        var id = Guid.Parse(User.Identity?.Name);
        var query = new GetMainPageQuery(){ UserId = id};;
        var result = await _queryDispatcher.SendAsync(query);
        return Ok(result);
    }
    [HttpPost("Seed")]
    public async Task<IActionResult> AddFewMovies()
    {
        await _context.Seed();
        return NoContent();
    }
    
}