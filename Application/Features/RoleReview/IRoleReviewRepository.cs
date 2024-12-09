namespace Application.Features.RoleReview;
using Domain.Entities;
public interface IRoleReviewRepository
{
    Task<RoleReview> GetAsync(Guid Id);
    Task<IEnumerable<RoleReview>> GetAllAsync();
    Task<IEnumerable<RoleReview>> GetAllAsyncFromRole(Guid Id);
    Task AddAsync(RoleReview roleReview);
    Task UpdateAsync(RoleReview roleReview);
    Task DeleteAsync(Guid Id);
    Task<bool> ExistsAsync(Guid Id);
    Task<bool> ExistsFromUser(Guid UserId, Guid RoleId);
}