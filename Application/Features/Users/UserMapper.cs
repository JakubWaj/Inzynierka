using Domain.Entities;

namespace Application.Features.Users;

public static class UserMapper
{
    public static UserDto MapToUserDto(this User user)
    {
        return new UserDto(user.Id, user.Login, user.Email);
    }
    
    public static IEnumerable<UserDto> MapToUsersDto(this IEnumerable<User> users)
    {
        return users.Select(x=>x.MapToUserDto());
    }
    
}