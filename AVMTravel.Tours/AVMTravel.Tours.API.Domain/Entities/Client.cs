using AVMTravel.Tours.API.Domain.Entities.Common;

namespace AVMTravel.Tours.API.Domain.Entities
{
    public class Client : AuditableBaseEntity
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }
    }
}
