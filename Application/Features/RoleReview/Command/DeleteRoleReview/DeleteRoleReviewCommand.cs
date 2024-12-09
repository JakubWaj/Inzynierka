using Application.Abstraction;

namespace Application.Features.RoleReview.Command.DeleteRoleReview;

public class DeleteRoleReviewCommand : ICommand<bool>
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
}