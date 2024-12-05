namespace Application.Features.Country;
using Domain.Entities;
public interface ICountryRepository
{
    Task<Country> GetAsync(Guid Id);
    Task<IEnumerable<Country>> GetAllAsync();
    Task<IEnumerable<Country>> GetCountiesByName(string[] counties);
    Task AddAsync(Country country);
    Task UpdateAsync(Country country);
    Task DeleteAsync(Guid Id);
    Task<bool> ExistsAsync(Guid Id);
}