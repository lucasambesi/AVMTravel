using AVMTravel.Tours.API.Application.Services;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using AVMTravel.Tours.API.Persistence.Percistence.Command;
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
            services.AddScoped<ITourService, TourService>();

            // Querys
            services.AddScoped<ILocationQuery, LocationQuery>();
            services.AddScoped<ITourQuery, TourQuery>();

            // Repositories
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ITourRepository, TourRepository>();

            return services;
        }
    }
}
