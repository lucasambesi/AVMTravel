using AVMTravel.Tours.API.Domain.Entities.Enums;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Reservation.V1.Create
{
    public class CreateReservationRequest : IRequest<CreateReservationResult>
    {
        public int ClientId { get; set; }
        
        public int TourId { get; set; }
    }
}
