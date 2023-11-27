using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Entities.Common;
using AVMTravel.Tours.API.Domain.Entities.Enums;

namespace AVMTravel.Tours.API.Domain.DTOs
{
    public class ReservationDto : AuditableBaseEntity
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public ClientDto? Client { get; set; }

        public int TourId { get; set; }

        public TourDto? Tour { get; set; }

        public EReservationStatus Status { get; set; }
    }
}
