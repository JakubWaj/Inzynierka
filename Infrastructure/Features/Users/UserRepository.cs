using Application.Features.Users;
using Domain.Entities;

namespace Infrastructure.Features.Users;

public class UserRepository : IUserRepository
{
    
    private readonly MoviesDbContext _context;

    public UserRepository(MoviesDbContext context)
    {
        _context = context;
    }

    
    public Task AddAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetAsync(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsAsync(Guid Id)
    {
        throw new NotImplementedException();
    }
}