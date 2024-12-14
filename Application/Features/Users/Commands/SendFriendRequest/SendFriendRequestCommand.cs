using Application.Abstraction;

namespace Application.Features.Users.Commands.SendFriendRequest;

public class SendFriendRequestCommand : ICommand<bool>
{
    public Guid UserId { get; set; }
    public Guid FriendId { get; set; }
}