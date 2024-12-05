using Application.Abstraction;
using Application.Features.Exceptions;

namespace Application.Features.Roles.Commands.DeleteRole;

public class DeleteRoleCommandHandler : ICommandHandler<DeleteRoleCommand,bool>
{
    private readonly IRoleRepository _roleRepository;

    public DeleteRoleCommandHandler(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }
    
    public async Task<bool> HandleAsync(DeleteRoleCommand command)
    {
        var exists = await _roleRepository.ExistsAsync(command.Id);
        
        if (!exists)
        {
            throw new NotFoundException("Role not found");
        }
        
        await _roleRepository.DeleteAsync(command.Id);
        return true;
    }
}