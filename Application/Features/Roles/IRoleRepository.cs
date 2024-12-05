using Domain.Entities;

namespace Application.Features.Roles;

public interface IRoleRepository
{
    Task<Role> GetAsync(Guid Id);
    Task<IEnumerable<Role>> GetAllAsync();
    Task<IEnumerable<Role>> GetAllFromPerson(Guid personId);
    Task AddAsync(Role movie);
    Task UpdateAsync(Role movie);
    Task DeleteAsync(Guid Id);
    Task<bool> ExistsAsync(Guid Id);
}