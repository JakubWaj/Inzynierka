using Application.Features.Movies;
using Domain.Common.Enums;
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

    public async Task<IEnumerable<Movie>> GetAllAsync()
    {
        return await _context.Movies.Include(x=>x.CountryOfMovie).ThenInclude(x=>x.Country).ToListAsync();
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
        return await _context.Movies.Include(x=>x.CountryOfMovie).ThenInclude(x=>x.Country).SingleOrDefaultAsync(x=>x.Id==Id);
    }

    public async Task<bool> ExistsAsync(Guid Id)
    {
        return await _context.Movies.AnyAsync(x=>x.Id==Id);
    }

    public Task<bool> ExistsAsyncWithTheSameTitle(string Title)
    {
        return _context.Movies.AnyAsync(x=>x.Title==Title);
    }

    public async Task<IEnumerable<Movie>> GetByTitleAsync(string Title)
    {
        return await _context.Movies.Include(x=>x.CountryOfMovie).ThenInclude(x=>x.Country).Where(x=>x.Title.Contains(Title)).ToListAsync();
    }

    public async Task<IEnumerable<Movie>> GetByGenreAsync(string Genre)
    {
        if (!Enum.TryParse<Genre>(Genre, out var parsedGenre))
        {
            throw new ArgumentException($"Invalid genre: {Genre}");
        }

        return await _context.Movies
            .Include(x=>x.CountryOfMovie)
            .ThenInclude(x=>x.Country)
            .Where(x => x.Genre == parsedGenre)
            .ToListAsync();
    }

    public async Task<IEnumerable<Movie>> GetByReleaseYearAsync(int ReleaseDate)
    {
        return await _context.Movies.Include(x=>x.CountryOfMovie).ThenInclude(x=>x.Country).Where(x=>x.ReleaseDate.Year==ReleaseDate).ToListAsync();
    }

    public async Task<IEnumerable<Movie>> GetByCountryAsync(Guid CountryId)
    {
        return await _context.Movies.Include(x=>x.CountryOfMovie).ThenInclude(x=>x.Country ).Where(x=>x.CountryOfMovie.Any(x=>x.CountryId==CountryId)).ToListAsync();
    }
}