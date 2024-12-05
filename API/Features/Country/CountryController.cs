using API.Controllers;
using Application.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace API.Features.Country;

public class CountryController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;

    public CountryController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
    {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
    }
    
    /*[HttpGet("{id}")]
    public async Task<IActionResult> GetCountryById(Guid id)
    {
        var query = new GetCountryQuery(id);
        var country = await _queryDispatcher.DispatchAsync(query);
        return Ok(country);
    }*/
}