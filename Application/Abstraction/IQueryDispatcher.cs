namespace Application.Abstraction;

public interface IQueryDispatcher
{
    Task<TResult> SendAsync<TResult>(IQuery<TResult> traceableQuery);
}