using Application.Abstraction;

namespace Application.Features.RoleReview.Command.UpdateRoleReview;

public class UpdateRoleReviewCommand :ICommand<bool>
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
    public int Rating { get; set; }
}