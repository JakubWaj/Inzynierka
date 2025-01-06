using Application.Abstraction;
using Application.Features.Users;

namespace Application.Command.UserCommands.SignUpUser;

public class SignUpUserCommand : ICommand<JwtDto>
{
    public Guid UserId { get; set; }
    public string Login { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}