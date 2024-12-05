using Application.Abstraction;
using Application.Features.Users.Exceptions;

namespace Application.Features.Users.Queries.GetUserByLogin;

public class GetUserByLoginQueryHandler : IQueryHandler<GetUserByLoginQuery, UserDto>
{
    private readonly IUserRepository _userRepository;

    public GetUserByLoginQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<UserDto> HandleAsync(GetUserByLoginQuery query)
    {
        var exists = await _userRepository.ExistsByLogin(query.Login);
        if (!exists)
        {
            var message = $"User with Login {query.Login} not found";
            throw new UserNotFoundException(message);
        }
        
        var user = await _userRepository.GetByEmail(query.Login);
        return user.MapToUserDto();
    }
}