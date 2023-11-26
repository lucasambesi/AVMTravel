using AVMTravel.Tours.API.Domain.Entities.Common;

namespace AVMTravel.Tours.API.Domain.DTOs
{
    public class LocationDto : AuditableBaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
