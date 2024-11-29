using Application.Abstraction;
using Application.Features.Movies;
using Application.Features.Movies.Commands.CreateMovie;
using Application.Features.Movies.Commands.DeleteMovie;
using Application.Features.Movies.Commands.UpdateMovie;
using Application.Features.Movies.Queries;
using Application.Features.Movies.Queries.GetAllMovies;
using Application.Features.Movies.Queries.GetMovie;
using Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

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
            Duration = movieRequest.Duration
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
}