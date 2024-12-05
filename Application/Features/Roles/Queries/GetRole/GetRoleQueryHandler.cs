using Application.Abstraction;
using Application.Features.Exceptions;

namespace Application.Features.Roles.Queries.GetRole;

public class GetRoleQueryHandler : IQueryHandler<GetRoleQuery, RoleDto>
{
    private readonly IRoleRepository _roleRepository;

    public GetRoleQueryHandler(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }
    
    public async Task<RoleDto> HandleAsync(GetRoleQuery query)
    {
        var exists = await  _roleRepository.ExistsAsync(query.Id);
        if (!exists)
        {
            throw new NotFoundException("Role not found");
        }
        var role = await _roleRepository.GetAsync(query.Id);
        return role.ToDto();
    }
}