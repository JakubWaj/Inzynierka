using Application.Abstraction;

namespace Application.Features.Roles.Commands.DeleteRole;

public class DeleteRoleCommand : ICommand<bool>
{
    public Guid Id { get; set; }
}