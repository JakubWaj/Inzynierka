using Application.Abstraction;

namespace Application.Features.Users.Commands.RemoveFromFriends;

public class RemoveFromFriendsCommandHandler : ICommandHandler<RemoveFromFriendsCommand,bool>
{
    private readonly IUserRepository _userRepository;

    public RemoveFromFriendsCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<bool> HandleAsync(RemoveFromFriendsCommand command)
    {
        await _userRepository.DeleteFriendAsync(command.UserId,command.FriendId);
        return true;
    }
}