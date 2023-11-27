using AVMTravel.Tours.API.Application.UseCases.Reservation.V1.UpdateStatus;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers;
using FluentValidation;

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
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(UpdateStatusReservationRequest.Id)));

            RuleFor(request => request.Status)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(UpdateStatusReservationRequest.Status)));            
        }

        private void EnumValidations()
        {
            RuleFor(x => x)
               .Must(request => BeAValidEnumValue((int)request.Status))
               .WithMessage(CommonHelper.IndalidFormatMessage(nameof(UpdateStatusReservationRequest.Status)));
        }     

        private bool BeAValidEnumValue(int value)
        {
            return Enum.IsDefined(typeof(EReservationStatus), value);
        }
    }
}
