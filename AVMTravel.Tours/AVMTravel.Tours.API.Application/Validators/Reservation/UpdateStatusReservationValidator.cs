using AVMTravel.Tours.API.Application.UseCases.Reservation.V1.UpdateStatus;
using AVMTravel.Tours.API.Domain.Helpers;
using FluentValidation;

namespace AVMTravel.Tours.API.Application.Validators.Reservation
{
    public class UpdateStatusReservationValidator : AbstractValidator<UpdateStatusReservationRequest>
    {
        public UpdateStatusReservationValidator()
        {
            MandatoryValidations();
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
    }
}
