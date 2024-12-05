using Application.Abstraction;
using Domain.Entities;

namespace Application.Features.Roles.Commands.AddRole;

public class AddRoleCommandHandler : ICommandHandler<AddRoleCommand,bool>
{
private readonly IRoleRepository _roleRepository;

public AddRoleCommandHandler(IRoleRepository roleRepository)
{
    _roleRepository = roleRepository;
}
    
public async Task<bool> HandleAsync(AddRoleCommand command)
{
    var role = new Role()
    {
        Id = command.Id,
        PersonId = command.PersonId,
        MovieId = command.MovieId,
        MovieProductionRole = command.MovieProductionRole,
        Character = command.Character,
    };
        
    await _roleRepository.AddAsync(role);
    return true;
        
        
}
}