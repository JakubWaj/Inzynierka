using Application.Security;
using Domain.Entities;
using Infrastructure.Auth;
using Infrastructure.Features;
using Infrastructure.Features.Users.Security;
using Infrastructure.Middleware;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class Extensions
{
    
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddPersistence(configuration);
        services.AddInfrastructureFeatures();
        services.AddScoped<ExceptionMiddleware>();
        services.AddAuth(configuration);
        services.AddTransient<ExceptionMiddleware>();
        services
            .AddSingleton<IPasswordHasher<User>, PasswordHasher<User>>()
            .AddSingleton<IPasswordManager, PasswordManager>();
        services.AddHttpContextAccessor();
        return services;
    }

    public static T GetOptions<T>(this IConfiguration configuration, string sectionName) where T : class, new()
    {
        var options = new T();
        var section = configuration.GetRequiredSection(sectionName);
        section.Bind(options);
        return options;
    }
}