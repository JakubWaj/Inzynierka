using Application.Abstraction;

namespace Application.Features.Users.Queries.GetAllUsers;

public class GetUsersQueryHandler : IQueryHandler<GetUsersQuery,IEnumerable<UserDto>>
{
    private readonly IUserRepository _userRepository;

    public GetUsersQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<IEnumerable<UserDto>> HandleAsync(GetUsersQuery query)
    {
        var users = await _userRepository.GetAsync();
        return users.MapToUsersDto();

    }
}