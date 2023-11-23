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
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IReservationService, ReservationService>();

            // Querys
            services.AddScoped<ILocationQuery, LocationQuery>();
            services.AddScoped<ITourQuery, TourQuery>();
            services.AddScoped<IClientQuery, ClientQuery>();
            services.AddScoped<IReservationQuery, ReservationQuery>();

            // Repositories
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ITourRepository, TourRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();

            return services;
        }
    }
}
