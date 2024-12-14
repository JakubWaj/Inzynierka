namespace Application.Features.Users;

public record UserDto(Guid Id,string Login,string Email);
public record UserFriendRequestDto(Guid Id,string Login,string Email);