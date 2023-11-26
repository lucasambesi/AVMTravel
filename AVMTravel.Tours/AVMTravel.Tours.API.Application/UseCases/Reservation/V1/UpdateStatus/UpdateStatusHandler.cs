using AutoMapper;
using AVMTravel.Tours.API.Application.Services;
using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Update;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Reservation.V1.UpdateStatus
{
    public class UpdateStatusHandler : IRequestHandler<UpdateStatusReservationRequest, UpdateStatusReservationResult>
    {
        private readonly IReservationService _reservationService;

        public UpdateStatusHandler(
            IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        public async Task<UpdateStatusReservationResult> Handle(
            UpdateStatusReservationRequest request,
            CancellationToken cancellationToken)
        {
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
