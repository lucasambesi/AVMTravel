﻿using AVMTravel.Tours.API.Application.Services;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using AVMTravel.Tours.API.Persistence.Percistence.Query;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace AVMTravel.Tours.API.Bootstrap.Providers.Cofigurations
{
    [ExcludeFromCodeCoverage]
    public static class AddServices
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            //Services
            services.AddScoped<ILocationService, LocationService>();

            // Querys & Repositories
            services.AddScoped<ILocationQuery, LocationQuery>();

            return services;
        }
    }
}
