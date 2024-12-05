using Application.Abstraction;

namespace Application.Features.Users.Queries.GetUserByEmail;

public class GetUserByEmailQuery : IQuery<UserDto>
{
    public string Email { get; set; }
}