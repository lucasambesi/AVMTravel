using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AVMTravel.Tours.API.Bootstrap.Providers.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddApplicationlayer(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }   
    }
}
