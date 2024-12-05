using Application.Abstraction;
using Application.Features.Users;
using Application.Features.Users.Commands.SignInUser;
using Application.Features.Users.Exceptions;
using Application.Security;
namespace Application.Command.UserCommands.SignInUser;

internal class SignInUserCommandHandler : ICommandHandler<SignInUserCommand,JwtDto>
{
    private readonly IUserRepository _accountRepository;
    private readonly IPasswordManager _passwordManager;
    private readonly IAuthenticator _authenticator;
    private readonly ITokenStorage _tokenManager;
    
    public SignInUserCommandHandler(IUserRepository accountRepository, ITokenStorage tokenManager, IAuthenticator authenticator, IPasswordManager passwordManager)
    {
        _accountRepository = accountRepository;
        _tokenManager = tokenManager;
        _authenticator = authenticator;
        _passwordManager = passwordManager;
    }
    
    public async Task<JwtDto> HandleAsync(SignInUserCommand command)
    {
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