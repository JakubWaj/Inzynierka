using Application.Features.Country;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Features.Country;

public class CountryRepository : ICountryRepository
{
    private readonly MoviesDbContext _context;

    public CountryRepository(MoviesDbContext context)
    {
        _context = context;
    }
    
    public async Task<Domain.Entities.Country> GetAsync(Guid Id)
    {
        return await _context
            .Countries
            .Include(c => c.Productions)
            .FirstOrDefaultAsync(x=>x.Id==Id);
    }

    public async Task<IEnumerable<Domain.Entities.Country>> GetAllAsync()
    {
        return await _context
            .Countries
            .Include(c => c.Productions)
            .ToListAsync();
    }

    public async Task<IEnumerable<Domain.Entities.Country>> GetCountiesByName(string[] counties)
    {
        return await _context
            .Countries
            .Where(x => counties.Contains(x.Name))
            .ToListAsync();
    }

    public async Task AddAsync(Domain.Entities.Country country)
    {
        await _context.Countries.AddAsync(country);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Domain.Entities.Country country)
    {
        _context.Countries.Update(country);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid Id)
    {
        var country = await GetAsync(Id);
        _context.Countries.Remove(country);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(Guid Id)
    {
        return await _context.Countries.AnyAsync(x => x.Id == Id);
    }
}