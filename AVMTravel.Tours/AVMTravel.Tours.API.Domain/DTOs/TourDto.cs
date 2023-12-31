﻿using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Entities.Common;

namespace AVMTravel.Tours.API.Domain.DTOs
{
    public class TourDto : AuditableBaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public int DurationHours { get; set; }

        public decimal Price { get; set; }

        public int LocationId { get; set; }

        public LocationDto? LocationDto { get; set; }

        public string? TourGuide { get; set; }

        public EDifficultyLevelType DifficultyLevel { get; set; }

        public bool Active { get; set; }
    }
}
