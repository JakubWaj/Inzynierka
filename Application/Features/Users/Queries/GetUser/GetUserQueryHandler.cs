using Application.Abstraction;
using Application.Features.Users.Exceptions;

namespace Application.Features.Users.Queries.GetUser;

public class GetUserQueryHandler : IQueryHandler<GetUserQuery, UserDto>
{
    private readonly IUserRepository _userRepository;

    public GetUserQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<UserDto> HandleAsync(GetUserQuery query)
    {
        var exists = await _userRepository.ExistsAsync(query.Id);
        if (!exists)
        {
            var message = $"User with Id {query.Id} not found";
            throw new UserNotFoundException(message);
        }
        var user = await _userRepository.GetAsync(query.Id);
        return user.MapToUserDto();
    }
}