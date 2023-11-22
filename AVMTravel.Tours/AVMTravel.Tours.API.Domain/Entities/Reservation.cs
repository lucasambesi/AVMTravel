using AVMTravel.Tours.API.Domain.Entities.Common;

namespace AVMTravel.Tours.API.Domain.Entities
{
    public class Reservation : AuditableBaseEntity
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int TourId { get; set; }
    }
}
