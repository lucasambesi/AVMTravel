﻿using AVMTravel.Tours.API.Application.UseCases.Reservation.V1.Create;
using AVMTravel.Tours.API.Domain.Helpers;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;

namespace AVMTravel.Tours.API.Application.Validators.Reservation
{
    public class CreateReservationValidator : AbstractValidator<CreateReservationRequest>
    {
        public CreateReservationValidator()
        {
            MandatoryValidations();
        }

        private void MandatoryValidations()
        {
            RuleFor(request => request.ClientId)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(CreateReservationRequest.ClientId)));

            RuleFor(request => request.TourId)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(CreateReservationRequest.TourId)));
        }
    }
}
