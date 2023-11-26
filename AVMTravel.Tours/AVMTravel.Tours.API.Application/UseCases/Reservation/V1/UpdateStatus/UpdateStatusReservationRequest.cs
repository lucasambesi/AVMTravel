using AVMTravel.Tours.API.Domain.Entities.Enums;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Reservation.V1.UpdateStatus
{
    public class UpdateStatusReservationRequest : IRequest<UpdateStatusReservationResult>
    {
        public int Id { get; set; }

        public EReservationStatus Status { get; set; }

        public UpdateStatusReservationRequest(int id, EReservationStatus status)
        {
            Id = id;
            Status = status;
        }
    }
}
