using API.Controllers;
using Application.Abstraction;
using Application.Features.People.Commands.CreatePerson;
using Application.Features.People.Commands.DeletePerson;
using Application.Features.People.Commands.UpdatePerson;
using Application.Features.People.Queries.GetPeople;
using Application.Features.People.Queries.GetPerson;
using Microsoft.AspNetCore.Mvc;

namespace API.Features.People;

public class PeopleController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;

    public PeopleController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
    {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
    }
    

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPersonById(Guid id)
    {
        var query = new GetPersonQuery(){Id=id};
        var person = await _queryDispatcher.SendAsync(query);
        return Ok(person);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetPeople()
    {
        var query = new GetPeopleQuery();
        var people = await _queryDispatcher.SendAsync(query);
        return Ok(people);
    }

    [HttpPost]
    public async Task<IActionResult> CreatePerson([FromBody] PersonRequests request)
    {
        var id = Guid.NewGuid();
        var command = new AddPersonCommand()
        {
            Id = id,
            FirstName = request.FirstName,
            LastName = request.LastName,
            BirthDate = request.BirthDate,
            Biography = request.Biography,
        };
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(new
        {
            Id = id,
            Result = result
        });
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePerson(Guid id)
    {
        var command = new DeletePersonCommand(){Id = id};
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(new
        {
            Id = id,
            Result = result
        });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePerson(Guid id, PersonRequests personRequests)
    {
        var command = new UpdatePersonCommand()
        {
            Id = id,
            FirstName = personRequests.FirstName,
            LastName = personRequests.LastName,
            BirthDate = personRequests.BirthDate,
            Biography = personRequests.Biography,
            
        };
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(new
        {
            Id = id,
            Result = result
        });
    }
}