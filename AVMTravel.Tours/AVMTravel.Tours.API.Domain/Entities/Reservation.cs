using AVMTravel.Tours.API.Domain.Entities.Common;
using AVMTravel.Tours.API.Domain.Entities.Enums;

namespace AVMTravel.Tours.API.Domain.Entities
{
    public class Reservation : AuditableBaseEntity
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public Client? Client { get; set; }

        public int TourId { get; set; }

        public Tour? Tour { get; set; }

        public EReservationStatus Status { get; set; }
    }
}
