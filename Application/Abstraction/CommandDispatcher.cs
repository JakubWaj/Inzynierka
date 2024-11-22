using Microsoft.Extensions.DependencyInjection;

namespace Application.Abstraction;

public class CommandDispatcher : ICommandDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public CommandDispatcher(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

    public async Task<TResult> SendAsync<TResult>(ICommand<TResult> Command)
    {
        var commandType = Command.GetType();
        var handlerType = typeof(ICommandHandler<,>).MakeGenericType(commandType, typeof(TResult));
        var handler = _serviceProvider.GetRequiredService(handlerType);
        var method = handlerType.GetMethod("HandleAsync");
        var task = (Task<TResult>)method.Invoke(handler, new object[] { Command });
        return await task;
    }
}