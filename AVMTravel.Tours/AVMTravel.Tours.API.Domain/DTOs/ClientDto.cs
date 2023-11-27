using AVMTravel.Tours.API.Domain.Entities.Common;

namespace AVMTravel.Tours.API.Domain.DTOs
{
    public class ClientDto : AuditableBaseEntity
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }
    }
}
