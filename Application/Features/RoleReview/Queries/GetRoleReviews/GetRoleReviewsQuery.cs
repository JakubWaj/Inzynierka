using Application.Abstraction;

namespace Application.Features.RoleReview.Queries.GetRoleReviews;

public class GetRoleReviewsQuery : IQuery<RoleReviewsDto>
{
    public Guid RoleId { get; set; }
}