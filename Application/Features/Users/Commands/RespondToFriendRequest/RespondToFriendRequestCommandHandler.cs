using Application.Abstraction;
using Domain.Common.Enums;

namespace Application.Features.Users.Commands.RespondToFriendRequest;

public class RespondToFriendRequestCommandHandler : ICommandHandler<RespondToFriendRequestCommand,Status>
{
    private readonly IUserRepository _userRepository;

    public RespondToFriendRequestCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<Status> HandleAsync(RespondToFriendRequestCommand command)
    {
        var user = await _userRepository.GetAsync(command.UserId);
        await _userRepository.RespondToFriendRequestAsync(command.RequestId,command.Accept?Status.Accepted:Status.Rejected);
        await _userRepository.UpdateAsync(user);
        return command.Accept?Status.Accepted:Status.Rejected;
    }
}