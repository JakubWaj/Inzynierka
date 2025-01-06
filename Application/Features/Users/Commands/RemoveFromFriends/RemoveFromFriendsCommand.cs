using Application.Abstraction;

namespace Application.Features.Users.Commands.RemoveFromFriends;

public class RemoveFromFriendsCommand : ICommand<bool>
{
    public Guid UserId { get; set; }
    public Guid FriendId { get; set; }
}