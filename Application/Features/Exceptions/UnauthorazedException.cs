using Application.Shared;

namespace Application.Features.Exceptions;

public class UnauthorazedException : BaseException
{
    public UnauthorazedException() : base( "Unauthorized")
    {
    }
}