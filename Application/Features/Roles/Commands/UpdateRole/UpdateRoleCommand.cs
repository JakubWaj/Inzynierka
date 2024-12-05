using Application.Abstraction;
using Domain.Common.Enums;
using Domain.Entities;

namespace Application.Features.Roles.Commands.UpdateRole;

public class UpdateRoleCommand : ICommand<bool>
{
    public Guid Id { get; set; }
    public Guid PersonId { get; set; }
    public Guid MovieId { get; set; }
    public MovieProductionRole MovieProductionRole { get; set; }
    public string? Character { get; set; }
}