using Application.Features.Country;
using Application.Features.MovieCountry;
using Application.Features.Movies;
using Application.Features.People;
using Application.Features.Reviews;
using Application.Features.RoleReview;
using Application.Features.Roles;
using Application.Features.Users;
using Infrastructure.Features.Country;
using Infrastructure.Features.MovieCountry;
using Infrastructure.Features.Movies;
using Infrastructure.Features.People;
using Infrastructure.Features.Reviews;
using Infrastructure.Features.RoleReviews;
using Infrastructure.Features.Roles;
using Infrastructure.Features.Users;
using Infrastructure.Persistence;
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
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<IMovieCountryRepository, MovieCountryRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<IRoleReviewRepository, RoleReviewRepository>();
        return services;
    }
}