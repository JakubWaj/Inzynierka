using Application.Abstraction;

namespace Application.Command.UserCommands.SignUpUser;

public class SignUpUserCommand : ICommand<bool>
{
    public Guid UserId { get; set; }
    public string Login { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}