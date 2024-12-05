using Application.Abstraction;

namespace Application.Features.Roles.Queries.GetRolesFromPerson;

public class GetRolesFromPersonQuery : IQuery<IEnumerable<RoleDto>>
{
    public Guid PersonId { get; set; }
}