﻿using Infrastructure.Persistence.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistence;

public static class Extensions
{
    private static string SqlServerOptions = "SqlServerOptions";
    public static IServiceCollection AddPersistence(this IServiceCollection services,IConfiguration configuration)
    {
        services.Configure<SqlServerOptions>(configuration.GetRequiredSection(SqlServerOptions));
        var databaseOptions = configuration.GetOptions<SqlServerOptions>(SqlServerOptions); 
        services.AddDbContext<MoviesDbContext>(opt => {
                opt.UseSqlServer(databaseOptions.ConnectionString); });
        return services;
    }
}