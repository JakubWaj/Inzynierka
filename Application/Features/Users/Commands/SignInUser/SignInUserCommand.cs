using Application.Abstraction;

namespace Application.Features.Users.Commands.SignInUser;

public class SignInUserCommand : ICommand<JwtDto>
{
    public string Email { get; set; }
    public string Password { get; set; }
}