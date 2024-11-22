using Application.Features.Movies;
using Application.Features.People;
using Application.Features.Reviews;
using Application.Features.Users;
using Infrastructure.Features.Movies;
using Infrastructure.Features.People;
using Infrastructure.Features.Reviews;
using Infrastructure.Features.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Features;

public static class Extensions
{
    public static IServiceCollection AddInfrastructureFeatures(this IServiceCollection services)
    {
        services.AddScoped<IMovieRepository, MovieRepository>();
        services.AddScoped<IReviewRepository, ReviewRepository>();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}