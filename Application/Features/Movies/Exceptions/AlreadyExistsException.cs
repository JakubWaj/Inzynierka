using Application.Shared;

namespace Application.Features.Movies.Exceptions;

public class AlreadyExistsException : BaseException
{
    public AlreadyExistsException() : base("Movie already exists in list")
    {
    }
}