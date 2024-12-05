using Domain.Entities;
namespace Application.Features.Users;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(Guid Id);
    Task<IEnumerable<User>> GetAsync();
    Task<User> GetAsync(Guid Id);
    Task<User> GetByEmail(string Email);
    Task<User> GetByLogin(string Login);
    Task<bool> ExistsAsync(Guid Id);
    Task<bool> ExistsByEmail(string Email);
    Task<bool> ExistsByLogin(string Login);
}