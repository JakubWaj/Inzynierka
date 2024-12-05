using Application.Shared;

namespace Application.Features.Users.Exceptions;

public class UserNotFoundException : BaseException
{
    public UserNotFoundException(string message) : base(message)
    {
    }
}