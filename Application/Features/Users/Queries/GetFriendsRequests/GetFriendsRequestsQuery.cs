using Application.Abstraction;

namespace Application.Features.Users.Queries.GetFriendsRequests;

public class GetFriendsRequestsQuery : IQuery<IEnumerable<UserFriendRequestDto>>
{
    public Guid UserId { get; set; }
    
}