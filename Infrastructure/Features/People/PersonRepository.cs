using Application.Features.People;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Features.People;

public class PersonRepository : IPersonRepository
{
    
    private readonly MoviesDbContext _context;

    public PersonRepository(MoviesDbContext context)
    {
        _context = context;
    }
    
    public async Task AddAsync(Person person)
    {
        await _context.People.AddAsync(person);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Person person)
    {
        _context.People.Update(person);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid Id)
    {
        var person = await _context.People.SingleOrDefaultAsync(x=>x.Id==Id);
        _context.People.Remove(person);
        await _context.SaveChangesAsync();
    }

    public async Task<Person> GetAsync(Guid Id)
    {
        return await _context.People.SingleOrDefaultAsync(x=>x.Id==Id);
    }

    public async Task<IEnumerable<Person>> GetAllAsync()
    {
        return await _context.People.ToListAsync();
    }

    public async Task<bool> ExistsAsync(Guid Id)
    {
        return await _context.People.AnyAsync(x=>x.Id==Id);
    }
}