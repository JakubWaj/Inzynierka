using Application.Abstraction;

namespace Application.Features.Users.Queries.GetFriends;

public class GetFriendsQueryHandler : IQueryHandler<GetFriendsQuery,IEnumerable<UserDto>>
{
    private readonly IUserRepository _userRepository;
    
    public GetFriendsQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<IEnumerable<UserDto>> HandleAsync(GetFriendsQuery query)
    {
        var user = await _userRepository.GetFriendsAsync(query.Id);
        return user.MapToUsersDto();
        
    }
}