using AVMTravel.Tours.API.Application.UseCases.Client.V1.Login;
using AVMTravel.Tours.API.Application.UseCases.Client.V1.Register;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create;
using AVMTravel.Tours.API.Application.UseCases.Reservation.V1.Create;
using AVMTravel.Tours.API.Application.UseCases.Reservation.V1.UpdateStatus;
using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Create;
using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Update;
using AVMTravel.Tours.API.Application.Validators.Client;
using AVMTravel.Tours.API.Application.Validators.Location;
using AVMTravel.Tours.API.Application.Validators.Reservation;
using AVMTravel.Tours.API.Application.Validators.Tour;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace AVMTravel.Tours.API.Bootstrap.Providers.Cofigurations
{
    [ExcludeFromCodeCoverage]
    public static class AddValidators
    {
        public static IServiceCollection ConfigureValidators(this IServiceCollection services)
        {
            services.AddTransient<IValidator<LoginRequest>, LoginValidator>();
            services.AddTransient<IValidator<RegisterRequest>, RegisterValidator>();
            services.AddTransient<IValidator<CreateLocationRequest>, CreateLocationValidator>();
            services.AddTransient<IValidator<CreateReservationRequest>, CreateReservationValidator>();
            services.AddTransient<IValidator<UpdateStatusReservationRequest>, UpdateStatusReservationValidator>();
            services.AddTransient<IValidator<CreateTourRequest>, CreateTourValidator>();
            services.AddTransient<IValidator<UpdateTourRequest>, UpdateTourValidator>();

            return services;
        }
    }
}
