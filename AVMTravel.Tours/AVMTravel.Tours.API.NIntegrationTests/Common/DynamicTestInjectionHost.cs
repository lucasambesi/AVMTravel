using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AVMTravel.Tours.API.NIntegrationTests.Common
{
    public abstract class DynamicTestInjectionHost
    {
        public IConfiguration Configuration { get; }

        public DynamicTestInjectionHost()
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true);
            Configuration = configurationBuilder.Build();
        }

        public TService GetService<TService>(Action<IServiceCollection, IConfiguration> configure)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(delegate (ILoggingBuilder opt)
            {
                opt.AddConsole();
            });
            configure(serviceCollection, Configuration);
            ServiceProvider provider = serviceCollection.BuildServiceProvider();
            return ServiceProviderServiceExtensions.GetRequiredService<TService>(provider);
        }
    }
}
