using Domain.Entities;

namespace Application.Features.Reviews;

public interface IReviewRepository
{
    Task<Review> GetAsync(Guid Id);
    Task<IEnumerable<Review>> GetAllAsync();
    Task AddAsync(Review movie);
    Task UpdateAsync(Review movie);
    Task DeleteAsync(Guid Id);
    Task<bool> ExistsAsync(Guid Id);
}