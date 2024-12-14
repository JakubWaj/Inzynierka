using Application.Abstraction;
using Domain.Common.Enums;

namespace Application.Features.Users.Commands.RespondToFriendRequest;

public class RespondToFriendRequestCommand : ICommand<Status>
{
    public Guid RequestId { get; set; }
    public Guid UserId { get; set; }
    public bool Accept { get; set; }
}