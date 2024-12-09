using Application.Abstraction;

namespace Application.Features.RoleReview.Queries.GetRoleReview;

public class GetRoleReviewQuery : IQuery<RoleReviewDto>
{
    public Guid Id { get; set; }
}