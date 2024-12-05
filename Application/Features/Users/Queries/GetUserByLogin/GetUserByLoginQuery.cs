using Application.Abstraction;

namespace Application.Features.Users.Queries.GetUserByLogin;

public class GetUserByLoginQuery : IQuery<UserDto>
{
    public string Login {get;set;}
}