using Application.Abstraction;

namespace Application.Features.RoleReview.Command.AddRoleReview;

public class AddRoleReviewCommand : ICommand<bool>
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
    
    public int Rating { get; set; } 
}