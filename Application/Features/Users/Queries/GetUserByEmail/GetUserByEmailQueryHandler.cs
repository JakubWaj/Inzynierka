using Application.Abstraction;
using Application.Features.Users.Exceptions;

namespace Application.Features.Users.Queries.GetUserByEmail;

public class GetUserByEmailQueryHandler : IQueryHandler<GetUserByEmailQuery, UserDto>
{
    private readonly IUserRepository _userRepository;

    public GetUserByEmailQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<UserDto> HandleAsync(GetUserByEmailQuery query)
    {
        var exists = await _userRepository.ExistsByEmail(query.Email);
        if (!exists)
        {
            var message = $"User with Email {query.Email} not found";
            throw new UserNotFoundException(message);
        }
        
        var user = await _userRepository.GetByEmail(query.Email);
        return user.MapToUserDto();
    }
}