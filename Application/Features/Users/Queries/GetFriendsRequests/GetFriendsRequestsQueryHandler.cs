using Application.Abstraction;
using Domain.Entities;

namespace Application.Features.Users.Queries.GetFriendsRequests;

public class GetFriendsRequestsQueryHandler : IQueryHandler<GetFriendsRequestsQuery,IEnumerable<UserFriendRequestDto>>
{
    private readonly IUserRepository _userRepository;

    public GetFriendsRequestsQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<UserFriendRequestDto>> HandleAsync(GetFriendsRequestsQuery query)
    {
        var userId = await _userRepository.GetFriendsRequestsAsync(query.UserId);
        var users = await _userRepository.GetFriendsRequestsUsersAsync(query.UserId);
        var xd = users.Join(userId, u => u.Id, i => i.FriendId, (u, i) => new {u,i});
        List<UserFriendRequestDto> userFriendRequestDtos = xd.Select(x=>new UserFriendRequestDto(x.i.Id,x.u.Login,x.u.Email)).ToList();
        return userFriendRequestDtos;
    }
}