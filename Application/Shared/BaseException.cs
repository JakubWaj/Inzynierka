namespace Application.Shared;

public class BaseException : Exception
{
    protected BaseException(string message) : base(message)
    {
    }
}