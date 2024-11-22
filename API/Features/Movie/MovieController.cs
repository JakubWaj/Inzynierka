using Application.Abstraction;
using Application.Features.Movies;
using Application.Features.Movies.Queries;
using Application.Features.Movies.Queries.GetMovie;
using Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class MovieController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;

    public MovieController(IQueryDispatcher queryDispatcher)
    {
        _queryDispatcher = queryDispatcher;
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetMovieAsync(Guid id)
    {
        var movie = new GetMovieQuery(id);
        var result = await _queryDispatcher.SendAsync(movie);
        return Ok(movie);
    }
}