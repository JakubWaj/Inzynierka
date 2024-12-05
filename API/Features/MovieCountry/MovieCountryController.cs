using API.Controllers;
using Application.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace API.Features.MovieCountry;

public class MovieCountryController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;

    public MovieCountryController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
    {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
    }
    
    /*[HttpGet("{id}")]
    public async Task<IActionResult> GetMovieCountryById(Guid id)
    {
        var query = new GetMovieCountryQuery(){Id=id};
        var movieCountry = await _queryDispatcher.SendAsync(query);
        return Ok(movieCountry);
    }*/
    
}