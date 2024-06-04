﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Cocktails.Application.Interfaces;

namespace Cocktails.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, 
            IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<CocktailsDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            services.AddScoped<ICocktailsDbContext>(provider => provider.GetService<CocktailsDbContext>());
            return services;
        }
    }
}
