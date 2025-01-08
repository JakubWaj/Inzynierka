using Application.Abstraction;

namespace Application.Features.Users.Queries.GetUsersActivity;

public class GetUsersActivityQuery : IQuery<ActivityDTO>
{
    public Guid UserId { get; set; }
}