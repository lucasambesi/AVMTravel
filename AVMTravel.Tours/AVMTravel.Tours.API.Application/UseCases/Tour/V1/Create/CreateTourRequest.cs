using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.Create
{
    public class CreateTourRequest : IRequest<CreateTourResult>
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public string? StartDate { get; set; }

        public int DurationHours { get; set; }

        public decimal Price { get; set; }

        public int LocationId { get; set; }

        public string? TourGuide { get; set; }

        public int DifficultyLevel { get; set; }
    }
}
