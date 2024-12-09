using Application.Abstraction;

namespace Application.Features.RoleReview.Queries.GetRoleReviews;

public class GetRoleReviewsQueryHandler : IQueryHandler<GetRoleReviewsQuery,RoleReviewsDto>
{
    private readonly IRoleReviewRepository _roleReviewRepository;

    public GetRoleReviewsQueryHandler(IRoleReviewRepository _roleReviewRepository)
    {
        this._roleReviewRepository = _roleReviewRepository;
    }
    
    public async Task<RoleReviewsDto> HandleAsync(GetRoleReviewsQuery query)
    {
        var roleReviews = await _roleReviewRepository.GetAllAsyncFromRole(query.RoleId);
        var ratings = roleReviews.Select(x => x.Rating);
        
        var roleReviewsDto = new RoleReviewsDto(ratings.Average(), query.RoleId,roleReviews.FirstOrDefault().Role.MovieProductionRole,roleReviews.FirstOrDefault().Role.Person.FirstName,roleReviews.FirstOrDefault().Role.Person.LastName);
        return roleReviewsDto;
    }
}