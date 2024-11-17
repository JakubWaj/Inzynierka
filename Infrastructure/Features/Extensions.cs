using Application.Features.Movies;
using Infrastructure.Features.Movies;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Features;

public static class Extensions
{
    public static IServiceCollection AddInfrastructureFeatures(this IServiceCollection services)
    {
        services.AddScoped<IMovieRepository, MovieRepository>();
        return services;
    }
}