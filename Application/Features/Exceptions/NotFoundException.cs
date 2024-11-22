using Application.Shared;

namespace Application.Features.Exceptions;

public class NotFoundException : BaseException
{
    public NotFoundException(string type) : base($"{type} not found")
    {
    }
}