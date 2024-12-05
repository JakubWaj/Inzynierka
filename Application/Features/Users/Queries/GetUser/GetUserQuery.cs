using Application.Abstraction;

namespace Application.Features.Users.Queries.GetUser;

public class GetUserQuery : IQuery<UserDto>
{
    public Guid Id { get; set; }
}