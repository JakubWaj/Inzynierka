using Application.Abstraction;
using Application.Features.Exceptions;
using Domain.Entities;

namespace Application.Features.Roles.Commands.UpdateRole;

public class UpdateRoleCommandHandler : ICommandHandler<UpdateRoleCommand, bool>
{
    private readonly IRoleRepository _roleRepository;

    public UpdateRoleCommandHandler(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }
    
    public async Task<bool> HandleAsync(UpdateRoleCommand command)
    {
        var exists = await _roleRepository.ExistsAsync(command.Id);
        if (!exists)
        {
            throw new NotFoundException("Role not found");
        }
        var role = new Role()
        {
            Id = command.Id,
            PersonId = command.PersonId,
            MovieId = command.MovieId,
            MovieProductionRole = command.MovieProductionRole,
            Character = command.Character,
        };
        await _roleRepository.UpdateAsync(role);
        return true;
    }
}