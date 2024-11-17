using Application.Features.Movies;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Features.Movies;

public class MovieRepository : IMovieRepository
{
    private readonly MoviesDbContext _context;

    public MovieRepository(MoviesDbContext context)
    {
        _context = context;
    }
    
    public async Task AddAsync(Movie movie)
    {
        await _context.Movies.AddAsync(movie);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Movie movie)
    {
         _context.Movies.Update(movie);
         await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid Id)
    {
        var movie = await _context.Movies.SingleOrDefaultAsync(x=>x.Id==Id);
        _context.Movies.Remove(movie);
        await _context.SaveChangesAsync();
    }

    public async Task<Movie> GetAsync(Guid Id)
    {
        return await _context.Movies.SingleOrDefaultAsync(x=>x.Id==Id);
    }

    public async Task<bool> ExistsAsync(Guid Id)
    {
        return await _context.Movies.AnyAsync(x=>x.Id==Id);
    }

    public Task<bool> ExistsAsyncWithTheSameTitle(string Title)
    {
        return _context.Movies.AnyAsync(x=>x.Title==Title);
    }
}