using Application.Features.Users;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Features.Users;

public class UserRepository : IUserRepository
{
    
    private readonly MoviesDbContext _context;

    public UserRepository(MoviesDbContext context)
    {
        _context = context;
    }

    
    public async Task AddAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid Id)
    {
        var user = await _context.Users.FindAsync(Id);
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<User>> GetAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User> GetAsync(Guid Id)
    {
        return await _context.Users.FindAsync(Id);
    }

    public async Task<User> GetByEmail(string Email)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Email == Email);
    }

    public async Task<User> GetByLogin(string Login)
    {
        return await _context.Users.FirstOrDefaultAsync(x => x.Login == Login);
    }

    public async Task<bool> ExistsAsync(Guid Id)
    {
        return await _context.Users.AnyAsync(x => x.Id == Id);
    }

    public async Task<bool> ExistsByEmail(string Email)
    {
        return await _context.Users.AnyAsync(x => x.Email == Email);
    }

    public async Task<bool> ExistsByLogin(string Login)
    {
        return await _context.Users.AnyAsync(x => x.Login == Login);
    }
}