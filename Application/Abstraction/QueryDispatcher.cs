using Microsoft.Extensions.DependencyInjection;

namespace Application.Abstraction;

public class QueryDispatcher : IQueryDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public QueryDispatcher(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

    public async Task<TResult> SendAsync<TResult>(IQuery<TResult> query)
    {
        var commandType = query.GetType();
        var handlerType = typeof(IQueryHandler<,>).MakeGenericType(commandType,typeof(TResult));
        var handler = _serviceProvider.GetRequiredService(handlerType);
        var method = handlerType.GetMethod("HandleAsync");
        var task = (Task<TResult>)method.Invoke(handler, new object[] { query });
        return await task;
    }
}