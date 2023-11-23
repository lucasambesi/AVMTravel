using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities.Enums;

namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.GetById
{
    public class GetByIdTourResult
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public int DurationHours { get; set; }

        public decimal Price { get; set; }

        public int LocationId { get; set; }

        public string? TourGuide { get; set; }

        public EDifficultyLevelType DifficultyLevel { get; set; }
    }
}
