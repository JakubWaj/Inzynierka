using Application.Abstraction;
using Domain.Entities;

namespace Application.Features.Users.Commands.SendFriendRequest;

public class SendFriendRequestCommandHandler : ICommandHandler<SendFriendRequestCommand,bool>
{
    private readonly IUserRepository _userRepository;

    public SendFriendRequestCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<bool> HandleAsync(SendFriendRequestCommand command)
    {
        var user = await _userRepository.GetAsync(command.UserId);
        var friend = await _userRepository.GetAsync(command.FriendId);
        if (user == null || friend == null)
        {
            return false;
        }
        var existing = await _userRepository.GetRequestAsync(command.UserId,command.FriendId);
        if (existing != null)
        {
            if (existing.Status == Domain.Common.Enums.Status.Accepted || existing.Status == Domain.Common.Enums.Status.Pending)
            {
                return false;
            }
        }
        var friendRequest = new UserFriends()
        {
            FriendId = command.FriendId,
            UserId = command.UserId,    
            Status = Domain.Common.Enums.Status.Pending
        };
        await _userRepository.SendFriendRequestAsync(friendRequest);
        return true;
    }
}