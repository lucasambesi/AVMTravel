using AVMTravel.Accommodation.API.Models;

namespace AVMTravel.Accommodation.API.Repositories.Interfaces
{
    public interface IHotelCollection
    {
        Task InsertHotel(Hotel hotel);

        Task InsertHotels(List<Hotel> hotels);

        Task<Hotel> GetHotel(string id);

        Task<List<Hotel>> GetHotels(int locationId);
    }
}
