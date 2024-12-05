using API.Controllers;
using Application.Abstraction;
using Application.Features.Country.Commands.AddCountry;
using Application.Features.Country.Commands.DeleteCountry;
using Application.Features.Country.Commands.UpdateCountry;
using Application.Features.Country.Queries.GetCountries;
using Application.Features.Country.Queries.GetCountry;
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
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCountryById(Guid id)
    {
        var query = new GetCountryQuery(){Id=id};
        var country = await _queryDispatcher.SendAsync(query);
        return Ok(country);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetCountries()
    {
        var query = new GetCountriesQuery();
        var countries = await _queryDispatcher.SendAsync(query);
        return Ok(countries);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateCountry([FromBody] CountryRequests request)
    {
        var id = Guid.NewGuid();
        
        var command = new AddCountryCommand()
        {
            Id = id,
            Name = request.Name,
        };
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(new
        {
            Id= id,
            Result= result
        });
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCountry(Guid id)
    {
        var command = new DeleteCountryCommand(){Id = id};
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(result);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCountry(Guid id, [FromBody] CountryRequests request)
    {
        var command = new UpdateCountryCommand()
        {
            Id = id,
            Name = request.Name,
        };
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(result);
    }
    
}