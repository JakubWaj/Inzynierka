using Application.Abstraction;

namespace Application.Features.Roles.Queries.GetRole;

public class GetRoleQuery : IQuery<RoleDto>
{
    public Guid Id { get; set; }
}