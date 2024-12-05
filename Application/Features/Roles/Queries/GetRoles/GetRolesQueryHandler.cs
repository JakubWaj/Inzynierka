using Application.Abstraction;

namespace Application.Features.Roles.Queries.GetRoles;

public class GetRolesQueryHandler : IQueryHandler<GetRolesQuery, IEnumerable<RoleDto>>
{
    private readonly IRoleRepository _roleRepository;

    public GetRolesQueryHandler(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }
    
    public async Task<IEnumerable<RoleDto>> HandleAsync(GetRolesQuery query)
    {
        var roles = await _roleRepository.GetAllAsync();
        return roles.Select(x => x.ToDto());
    }
}