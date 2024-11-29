using Domain.Entities;

namespace Application.Features.People;

public interface IPersonRepository
{
    Task AddAsync(Person person);
    Task UpdateAsync(Person person);
    Task DeleteAsync(Guid Id);
    Task<Person> GetAsync(Guid Id);
    Task<IEnumerable<Person>> GetAllAsync();
    Task<bool> ExistsAsync(Guid Id);
}