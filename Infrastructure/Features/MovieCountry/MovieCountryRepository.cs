using Application.Features.MovieCountry;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Features.MovieCountry;

public class MovieCountryRepository : IMovieCountryRepository
{
    private readonly MoviesDbContext _context;

    public MovieCountryRepository(MoviesDbContext context)
    {
        _context = context;
    }
    // do wyjebania
    public async Task<Domain.Entities.MovieCountry> GetAsync(Guid Id)
    {
        return await _context
            .MovieCountries
            .FirstOrDefaultAsync(x=>x.CountryId==Id); 
    }

    public async Task<IEnumerable<Domain.Entities.MovieCountry>> GetAllAsync()
    {
        return await _context
            .MovieCountries
            .ToListAsync();
    }

    public Task<IEnumerable<Domain.Entities.MovieCountry>> GetAllMoviesFromCountry()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Domain.Entities.MovieCountry>> GetAllCountriesForMovie()
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Domain.Entities.MovieCountry movieCountry)
    {
        await _context.MovieCountries.AddAsync(movieCountry);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Domain.Entities.MovieCountry movieCountry)
    {
        _context.MovieCountries.Update(movieCountry);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid Id)
    {
        var movieCountry = await GetAsync(Id);
        _context.MovieCountries.Remove(movieCountry);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(Guid Id)
    {
        return await _context.MovieCountries.AnyAsync(x => x.CountryId == Id);
    }
}