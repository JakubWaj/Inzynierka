using System.Windows.Input;
using Application.Abstraction;
using FluentValidation;

namespace Application.Decorators;

public sealed class CommandDispatcherDecoratorHandler : ICommandDispatcher
{
    private readonly ICommandDispatcher _decoratedDispatcher;
    private readonly IServiceProvider _serviceProvider;

    public CommandDispatcherDecoratorHandler(ICommandDispatcher decoratedDispatcher, IServiceProvider serviceProvider)
    {
        _decoratedDispatcher = decoratedDispatcher;
        _serviceProvider = serviceProvider;
    }
    
    public async Task<TResult> SendAsync<TResult>(ICommand<TResult> command)
    {
        if (command == null)
        {
            throw new ArgumentNullException(nameof(command));
        }
        var commandType = command.GetType();
        var validatorType = typeof(IValidator<>).MakeGenericType(commandType);
        var validator = _serviceProvider.GetService(validatorType) as IValidator;

        if (validator != null)
        {
            var contextType = typeof(ValidationContext<>).MakeGenericType(commandType);
            var context = Activator.CreateInstance(contextType, command);
            var validationResult = await validator.ValidateAsync((IValidationContext)context);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }
        }
        var tresult = await _decoratedDispatcher.SendAsync(command);
        return tresult;
    }
}
