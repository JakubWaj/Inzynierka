using Application.Shared;

namespace Application.Features.Users.Exceptions;

public class InvalidCredentialsException : BaseException
{
    public InvalidCredentialsException() : base("Invalid credentials")
    {
    }
}