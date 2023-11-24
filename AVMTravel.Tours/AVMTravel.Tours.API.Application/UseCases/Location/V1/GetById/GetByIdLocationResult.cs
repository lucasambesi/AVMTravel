using AVMTravel.Tours.API.ApiClients.Dtos.Accommodation;

namespace AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById
{
    public class GetByIdLocationResult
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<HotelDto>? Hotels { get; set; }
    }
}
