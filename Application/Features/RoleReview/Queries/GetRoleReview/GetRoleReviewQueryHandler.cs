using Application.Abstraction;
using Application.Features.Exceptions;

namespace Application.Features.RoleReview.Queries.GetRoleReview;

public class GetRoleReviewQueryHandler : IQueryHandler<GetRoleReviewQuery,RoleReviewDto>
{
    private readonly IRoleReviewRepository _roleReviewRepository;

    public GetRoleReviewQueryHandler(IRoleReviewRepository roleReviewRepository)
    {
        _roleReviewRepository = roleReviewRepository;
    }
    
    public async Task<RoleReviewDto> HandleAsync(GetRoleReviewQuery query)
    {
        var exists = await _roleReviewRepository.ExistsAsync(query.Id);
        if (!exists)
        {
            throw new NotFoundException("Review was not found");
        }
        var roleReview = await _roleReviewRepository.GetAsync(query.Id);

        var roleReviewDto = new RoleReviewDto(roleReview.Rating,
            roleReview.RoleId,
            roleReview.Role.MovieProductionRole,
            roleReview.Role.Person.FirstName,
            roleReview.Role.Person.LastName,
            roleReview.CreatedAt);
        return roleReviewDto;
    }
}