using AVMTravel.Tours.API.Application.UseCases.Reservation.V1.UpdateStatus;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using FluentValidation;
using System;

namespace AVMTravel.Tours.API.Application.Validators.Reservation
{
    public class UpdateStatusReservationValidator : AbstractValidator<UpdateStatusReservationRequest>
    {
        public UpdateStatusReservationValidator()
        {
            MandatoryValidations();
            EnumValidations();
        }

        private void MandatoryValidations()
        {
            RuleFor(request => request.Id)
                .NotEmpty()
                .WithMessage("The id cannot be empty");

            RuleFor(request => request.Status)
                .NotEmpty()
                .WithMessage("The status cannot be empty");
        }

        private void EnumValidations()
        {
            RuleFor(x => x)
               .Must(request => BeAValidEnumValue((int)request.Status))
               .WithMessage("Status invalid format");
        }     

        private bool BeAValidEnumValue(int value)
        {
            return Enum.IsDefined(typeof(EReservationStatus), value);
        }
    }
}
