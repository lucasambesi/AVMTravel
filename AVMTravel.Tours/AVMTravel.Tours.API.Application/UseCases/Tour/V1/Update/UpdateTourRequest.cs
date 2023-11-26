using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.Update
{
    public class UpdateTourRequest : IRequest<UpdateTourResult>
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? StartDate { get; set; }

        public int DurationHours { get; set; }

        public decimal Price { get; set; }

        public int LocationId { get; set; }

        public string? TourGuide { get; set; }

        public int DifficultyLevel { get; set; }
    }
}
