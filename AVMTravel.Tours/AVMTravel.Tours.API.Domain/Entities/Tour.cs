using AVMTravel.Tours.API.Domain.Entities.Common;
using AVMTravel.Tours.API.Domain.Entities.Enums;

namespace AVMTravel.Tours.API.Domain.Entities
{
    public class Tour : AuditableBaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public int DurationHours { get; set; }

        public decimal Price { get; set; }

        public int LocationId { get; set; }

        public Location? Location { get; set; }

        public string? TourGuide { get; set; }

        public EDifficultyLevelType DifficultyLevel { get; set; }
    }
}
