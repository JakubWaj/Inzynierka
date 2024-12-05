using Application.Features.Reviews;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Features.Reviews;

public class ReviewRepository : IReviewRepository
{
    
    private readonly MoviesDbContext _context;

    public ReviewRepository(MoviesDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Review>> GetAllAsync()
    {
        return await _context.Reviews.ToListAsync();
    }

    public async Task AddAsync(Review review)
    {
        await _context.Reviews.AddAsync(review);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Review review)
    {
        _context.Reviews.Update(review);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid Id)
    {
        var review = await _context.Reviews.SingleOrDefaultAsync(x=>x.Id==Id);
        _context.Reviews.Remove(review);
        await _context.SaveChangesAsync();
    }

    public async Task<Review> GetAsync(Guid Id)
    {
        return await _context.Reviews.SingleOrDefaultAsync(x=>x.Id==Id);
    }

    public async Task<bool> ExistsAsync(Guid Id)
    {
        return await _context.Reviews.AnyAsync(x=>x.Id==Id);
    }

    public async Task<bool> ExistsAsync(Guid MovieId, Guid UserId)
    {
        return await _context.Reviews.AnyAsync(x=>x.MovieId==MovieId && x.UserId==UserId);
    }
}