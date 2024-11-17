using Domain.Entities;
namespace Application.Features.Users;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(Guid Id);
    Task<User> GetAsync(Guid Id);
    Task<bool> ExistsAsync(Guid Id);
}