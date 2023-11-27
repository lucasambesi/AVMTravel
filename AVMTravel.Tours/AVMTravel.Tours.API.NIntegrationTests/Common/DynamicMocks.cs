using AVMTravel.Tours.API.ApiClients;
using AVMTravel.Tours.API.ApiClients.Dtos.Accommodation;
using AVMTravel.Tours.API.Application.Services;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById;
using AVMTravel.Tours.API.Application.Validators.Location;
using AVMTravel.Tours.API.Bootstrap.Providers.Cofigurations;
using AVMTravel.Tours.API.Controllers.Location.V1;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using AVMTravel.Tours.API.Persistence.Contexts;
using AVMTravel.Tours.API.Persistence.Percistence.Command;
using AVMTravel.Tours.API.Persistence.Percistence.Query;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System.Reflection;

namespace AVMTravel.Tours.API.NIntegrationTests.Common
{
    public class DynamicMocks
    {

        public static void ConfigureLocationController(IServiceCollection services, IConfiguration configuration)
        {
            //Base mock
            ConfigureBaseMocks(services);

            //Controller mediator
            services.AddScoped((provider) => new LocationController(provider.GetRequiredService<IMediator>()));
            services.AddMediatR(typeof(GetByIdHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(CreateHandler).GetTypeInfo().Assembly);

            //Services clients
            IEnumerable<HotelDto> hotelDtos = new List<HotelDto>();
            var accommodationServiceClient = new Mock<IAccommodationServiceClient>();

            accommodationServiceClient
                .Setup(x => x.GetHotelByLocationIdAsync(It.IsAny<int>()))
                .ReturnsAsync(hotelDtos);

            services.AddScoped((provider) => accommodationServiceClient.Object);

            //Internal services
            services
                .AddTransient<IValidator<CreateLocationRequest>, CreateLocationValidator>()
                .AddScoped<ILocationService, LocationService>()
                .AddScoped<ILocationRepository, LocationRepository>()
                .AddScoped<ILocationQuery, LocationQuery>();       
        }

        private static void ConfigureBaseMocks(IServiceCollection services)
        {            
            services.AddDbContext<BaseContext>(options => options.UseInMemoryDatabase(databaseName: $"AVMTrave.Tours-{new Guid()}"));

            var mapConfig = new MapperMock();
            var mapper = mapConfig.GetMapper();
            services.AddSingleton(mapper);
        }
    }
}
