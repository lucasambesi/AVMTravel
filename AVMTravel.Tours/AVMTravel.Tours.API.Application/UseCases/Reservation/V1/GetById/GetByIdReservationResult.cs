using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities.Enums;

namespace AVMTravel.Tours.API.Application.UseCases.Reservation.V1.GetById
{
    public class GetByIdReservationResult
    {
        public int Id { get; set; }

        public ClientDto? Client { get; set; }

        public TourDto? Tour { get; set; }

        public EReservationStatus Status { get; set; }
    }
}
