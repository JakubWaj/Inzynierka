using Application.Features.Movies;
using Application.Features.Movies.Queries;
using Application.Abstraction;
using Application.Decorators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddHandlers();
        services.AddScoped<ICommandDispatcher,CommandDispatcher>();
        services.AddScoped<IQueryDispatcher, QueryDispatcher>();
        services.Decorate<ICommandDispatcher, CommandDispatcherDecoratorHandler>();
        services.AddValidatorsFromAssemblyContaining(typeof(ApplicationReference), ServiceLifetime.Transient);
        var applicationAssembly = typeof(IQueryHandler<,>).Assembly;
        return services;
    }   
}