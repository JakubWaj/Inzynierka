using Application.Abstraction;
using Application.Features.Exceptions;
using Application.Features.People;

namespace Application.Features.Roles.Queries.GetRolesFromPerson;

public class GetRolesFromPersonQueryHandler : IQueryHandler<GetRolesFromPersonQuery, IEnumerable<RoleDto>>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IPersonRepository _personRepository;

    public GetRolesFromPersonQueryHandler(IRoleRepository roleRepository,IPersonRepository personRepository)
    {
        _roleRepository = roleRepository;
        _personRepository = personRepository;
    }
    
    public async Task<IEnumerable<RoleDto>> HandleAsync(GetRolesFromPersonQuery query)
    {
        var exists = await _personRepository.ExistsAsync(query.PersonId);
        if (!exists)
        {
            throw new NotFoundException("Person not found");
        }
        var roles = await _roleRepository.GetAllFromPerson(query.PersonId);
        return roles.ToDto();
    }
}