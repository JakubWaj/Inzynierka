using Application.Features.RoleReview;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Features.RoleReviews;

public class RoleReviewRepository : IRoleReviewRepository
{
    private readonly MoviesDbContext _context;

    public RoleReviewRepository(MoviesDbContext context)
    {
        _context = context;
    }
    
    public async Task<RoleReview> GetAsync(Guid Id)
    {
        return await _context
            .RoleReviews.Include(x=>x.Role).ThenInclude(x=>x.Person)
            .FirstOrDefaultAsync(x=>x.Id==Id);
    }

    public async Task<IEnumerable<RoleReview>> GetAllAsync()
    {
        return await _context
            .RoleReviews
            .ToListAsync();
    }

    public async Task<IEnumerable<RoleReview>> GetAllAsyncFromRole(Guid Id)
    {
        return await _context
            .RoleReviews
            .Where(x => x.RoleId == Id)
            .ToListAsync();
    }

    public async Task AddAsync(RoleReview roleReview)
    {
        await _context.RoleReviews.AddAsync(roleReview);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(RoleReview roleReview)
    {
        _context.RoleReviews.Update(roleReview);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid Id)
    {
        var roleReview = await GetAsync(Id);
        _context.RoleReviews.Remove(roleReview);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(Guid Id)
    {
        return await _context.RoleReviews.AnyAsync(x => x.Id == Id);
    }

    public async Task<bool> ExistsFromUser(Guid UserId, Guid RoleId)
    {
        return await _context.RoleReviews.Where(x => x.UserId == UserId).AnyAsync(x => x.RoleId == RoleId);
    }
}