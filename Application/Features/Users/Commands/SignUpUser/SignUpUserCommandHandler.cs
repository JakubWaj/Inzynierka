using Application.Abstraction;
using Application.Command.UserCommands.SignUpUser;
using Application.Features.Users.Exceptions;
using Application.Security;
using Domain.Entities;

namespace Application.Features.Users.Commands.SignUpUser;

internal class SignUpUserCommandHandler : ICommandHandler<SignUpUserCommand, JwtDto>
{
    private readonly IUserRepository _accountRepository;
    private readonly IPasswordManager _passwordManager;
    private readonly IAuthenticator _authenticator;
    private readonly ITokenStorage _tokenManager;
    public SignUpUserCommandHandler(IUserRepository accountRepository, IPasswordManager passwordManager, IAuthenticator authenticator, ITokenStorage tokenManager)
    {
        _accountRepository = accountRepository;
        _passwordManager = passwordManager;
        _authenticator = authenticator;
        _tokenManager = tokenManager;
    }



    public async Task<JwtDto> HandleAsync(SignUpUserCommand command)
    {
       
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
        var user = await _accountRepository.GetByEmail(command.Email);
        var exists = await _accountRepository.ExistsByEmail(command.Email);
        if (!exists)
        {
            throw new InvalidCredentialsException();
        }
        
        if (!_passwordManager.Validate(command.Password, user.Password))
        {
            throw new InvalidCredentialsException();
        }

        if (_passwordManager.Validate(command.Password, user.Password))
        {
            var jwt = _authenticator.CreateToken(user.Id);
            _tokenManager.Set(jwt);
            return jwt;
        }
        throw new InvalidCredentialsException();
    }
}