using Domain.Common.Enums;

namespace Domain.Entities;

public class UserFriends
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid FriendId { get; set; }
    public Status Status { get; set; }
}