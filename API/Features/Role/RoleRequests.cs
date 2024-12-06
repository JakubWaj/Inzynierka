using Domain.Common.Enums;

namespace API.Features.Role;

public record RoleRequests(Guid PersonId, Guid MovieId, MovieProductionRole MovieProductionRole, string? Character);
