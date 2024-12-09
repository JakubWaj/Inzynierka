using Application.Abstraction;
using Application.Command.UserCommands.SignUpUser;
using Application.Features.Users.Exceptions;
using Application.Security;
using Domain.Entities;

namespace Application.Features.Users.Commands.SignUpUser;

internal class SignUpUserCommandHandler : ICommandHandler<SignUpUserCommand, bool>
{
    private readonly IUserRepository _accountRepository;
    private readonly IPasswordManager _passwordManager;

    public SignUpUserCommandHandler(IUserRepository accountRepository, IPasswordManager passwordManager)
    {
        _accountRepository = accountRepository;
        _passwordManager = passwordManager;
    }



    public async Task<bool> HandleAsync(SignUpUserCommand command)
    {
        var user = await _accountRepository.GetByEmail(command.Email);
        var emailUnique = await _accountRepository.ExistsByEmail(command.Email);
        var loginUnique = await _accountRepository.ExistsByLogin(command.Login);
        if (emailUnique || loginUnique)
        {
            throw new UserAlreadyExistsException();
        }
        var securedPassword = _passwordManager.Secure(command.Password);
        User newUser = new User()
        {
            Id = command.UserId,
            Email = command.Email,
            Login = command.Login,
            Password = securedPassword
        };
        await _accountRepository.AddAsync(newUser);
        return true;
    }
}