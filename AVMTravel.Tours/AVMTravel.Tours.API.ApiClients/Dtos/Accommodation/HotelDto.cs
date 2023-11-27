using System.Diagnostics.CodeAnalysis;

namespace AVMTravel.Tours.API.ApiClients.Dtos.Accommodation
{
    [ExcludeFromCodeCoverage]
    public class HotelDto
    {
        public string? HotelId { get; set; }

        public int LocationId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public double Rating { get; set; }
    }
}
