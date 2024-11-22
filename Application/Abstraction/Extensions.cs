using Microsoft.Extensions.DependencyInjection;

namespace Application.Abstraction;

public static class Extensions
{
    public static IServiceCollection AddHandlers(this IServiceCollection services)
    {
        services.Scan(selector =>
        {
            selector.FromAssemblies(ApplicationReference.Assembly)
                .AddClasses(filter =>
                {
                    filter.AssignableTo(typeof(ICommandHandler<,>)).Where(type => type.IsClass && !type.IsAbstract);
                })
                .AsImplementedInterfaces()
                .WithTransientLifetime();
        });

        services.Scan(selector =>
        {
            selector.FromAssemblies(ApplicationReference.Assembly)
                .AddClasses(filter =>
                {
                    filter.AssignableTo(typeof(IQueryHandler<,>));
                })
                .AsImplementedInterfaces()
                .WithTransientLifetime();
        });
        return services;
    }
}