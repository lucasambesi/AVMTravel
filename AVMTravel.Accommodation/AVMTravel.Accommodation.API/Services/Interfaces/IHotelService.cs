using AVMTravel.Accommodation.API.Models;

namespace AVMTravel.Accommodation.API.Services.Interfaces
{
    public interface IHotelService
    {
        Task InsertHotel(Hotel hotel);

        Task InsertHotels(List<Hotel> hotels);

        Task<Hotel> GetHotel(string id);

        Task<List<Hotel>> GetHotels(int locationId);
    }
}
