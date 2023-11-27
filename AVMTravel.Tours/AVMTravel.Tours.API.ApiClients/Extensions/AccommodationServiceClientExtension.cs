using Microsoft.Extensions.DependencyInjection;
using Refit;
using Microsoft.Extensions.Configuration;

namespace AVMTravel.Tours.API.ApiClients.Extensions
{
    public static class AccommodationServiceClientExtension
    {
        private static void AddAccommodationServiceClient(
            this IServiceCollection services,
            string url)
        {
            services.AddRefitClient<IAccommodationServiceClient>()
                    .ConfigureHttpClient(client => client.BaseAddress = new Uri(url));
        }

        public static void AddAccommodationServiceClient(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var url = configuration.GetSection("AccommodationServiceUrl").Value;
            AddAccommodationServiceClient(services, url);
        }
    }
}
