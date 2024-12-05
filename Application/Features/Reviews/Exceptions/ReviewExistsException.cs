using Application.Shared;

namespace Application.Features.Reviews.Exceptions;

public class ReviewExistsException : BaseException
{
    public ReviewExistsException(string message) : base(message)
    {
    }
}