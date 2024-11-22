namespace Application.Abstraction;

public interface ICommandDispatcher
{
    Task<TResult> SendAsync<TResult>(ICommand<TResult> Command);
}