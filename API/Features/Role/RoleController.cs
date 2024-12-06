using API.Controllers;
using Application.Abstraction;
using Application.Features.Roles.Commands.AddRole;
using Application.Features.Roles.Commands.DeleteRole;
using Application.Features.Roles.Commands.UpdateRole;
using Application.Features.Roles.Queries.GetRole;
using Application.Features.Roles.Queries.GetRoles;
using Microsoft.AspNetCore.Mvc;

namespace API.Features.Role;

public class RoleController : BaseController
{
    private readonly IQueryDispatcher _queryDispatcher;
    private readonly ICommandDispatcher _commandDispatcher;

    public RoleController(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
    {
        _queryDispatcher = queryDispatcher;
        _commandDispatcher = commandDispatcher;
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetRoleById(Guid id)
    {
        var query = new GetRoleQuery(){Id=id};
        var role = await _queryDispatcher.SendAsync(query);
        return Ok(role);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetRoles()
    {
        var query = new GetRolesQuery();
        var roles = await _queryDispatcher.SendAsync(query);
        return Ok(roles);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateRole([FromBody] RoleRequests request)
    {
        var id = Guid.NewGuid();
        
        var command = new AddRoleCommand()
        {
            Id = id,
            MovieProductionRole = request.MovieProductionRole,
            Character = request.Character,
            MovieId = request.MovieId,
            PersonId = request.PersonId
        };
        
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(new
        {
            Id= id,
            Result= result
        });
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateRole(Guid id, [FromBody] RoleRequests request)
    {
        var command = new UpdateRoleCommand()
        {
            Id = id,
            MovieProductionRole = request.MovieProductionRole,
            Character = request.Character,
            MovieId = request.MovieId,
            PersonId = request.PersonId
        };
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(new
        {
            Id = id,
            Result = result
        });
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRole(Guid id)
    {
        var command = new DeleteRoleCommand(){Id = id};
        var result = await _commandDispatcher.SendAsync(command);
        return Ok(new
        {
            Id = id,
            Result = result
        });
    }
}