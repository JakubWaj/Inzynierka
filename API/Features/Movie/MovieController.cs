using Application.Abstraction;
using Application.Features.Movies;
using Application.Features.Movies.Queries;
using Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class MovieController : BaseController
{
    private readonly IQueryHandler<GetMovieQuery,MovieDto> _queryDispatcher;

    public MovieController(IQueryHandler<GetMovieQuery, MovieDto> queryDispatcher)
    {
        _queryDispatcher = queryDispatcher;
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetMovieAsync(Guid id)
    {
        var movie = await _queryDispatcher.HandleAsync(new GetMovieQuery(id));
        return Ok(movie);
    }
}