using Application.Abstraction;

namespace Application.Features.Users.Queries.GetFriends;

public class GetFriendsQuery : IQuery<IEnumerable<UserDto>>
{
    public Guid Id { get; set; }
    
}