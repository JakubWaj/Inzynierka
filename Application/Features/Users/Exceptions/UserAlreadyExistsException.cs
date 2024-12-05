using Application.Shared;

namespace Application.Features.Users.Exceptions;

public class UserAlreadyExistsException : BaseException
{
    public UserAlreadyExistsException( ) : base("user with email already exists")
    {
    }
}