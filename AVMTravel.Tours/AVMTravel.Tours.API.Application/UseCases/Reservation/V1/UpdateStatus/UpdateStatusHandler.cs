using AVMTravel.Tours.API.Application.UseCases.Client.V1.Login;
using AVMTravel.Tours.API.Application.Validators.Client;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using FluentValidation;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Reservation.V1.UpdateStatus
{
    public class UpdateStatusHandler : IRequestHandler<UpdateStatusReservationRequest, UpdateStatusReservationResult>
    {
        private readonly IReservationService _reservationService;

        private readonly IValidator<UpdateStatusReservationRequest> _updateStatusValidator;

        public UpdateStatusHandler(
            IReservationService reservationService, 
            IValidator<UpdateStatusReservationRequest> updateStatusValidator)
        {
            _reservationService = reservationService;
            _updateStatusValidator = updateStatusValidator;
        }

        public async Task<UpdateStatusReservationResult> Handle(
            UpdateStatusReservationRequest request,
            CancellationToken cancellationToken)
        {
            var validationResult = _updateStatusValidator.Validate(request);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ValidationApiException(errors);
            }

            var reservation = await _reservationService.GetByIdAsync(request.Id, false);

            if (reservation == null)
            {
                throw new ApplicationApiException("Entity not found", EErrorCodeType.NotFound);
            }

            var result = await _reservationService.UpdateStatusAsync(reservation, request.Status);

            return new UpdateStatusReservationResult(result);
        }
    }
}
