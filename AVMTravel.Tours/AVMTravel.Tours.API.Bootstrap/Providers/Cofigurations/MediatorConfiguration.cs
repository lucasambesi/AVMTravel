﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace AVMTravel.Tours.API.Bootstrap.Providers.Cofigurations
{
    [ExcludeFromCodeCoverage]
    public static class MediatorConfiguration
    {
        private const string APPLICATION_NAMESPACE = "AVMTravel.Tours.API.Application";

        public static IServiceCollection ConfigureMediatrServices(this IServiceCollection services)
        {
            var types = Assembly.Load(APPLICATION_NAMESPACE).GetTypes()
                .Where(a => (a.IsClass && a.Namespace != null && a.Name.EndsWith("Handler"))).ToArray();

            services.AddMediatR(types);

            return services;
        }
    }
}
