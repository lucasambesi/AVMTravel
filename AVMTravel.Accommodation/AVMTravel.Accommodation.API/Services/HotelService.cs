using AVMTravel.Accommodation.API.Models;
using AVMTravel.Accommodation.API.Repositories.Interfaces;
using AVMTravel.Accommodation.API.Services.Interfaces;

namespace AVMTravel.Accommodation.API.Services
{
    public class HotelService : IHotelService
    {
        internal IHotelCollection _hotelCollection;

        public HotelService(IHotelCollection hotelCollection)
        {
            _hotelCollection = hotelCollection;
        }
        public async Task InsertHotel(Hotel hotel)
        {
            await _hotelCollection.InsertHotel(hotel);
        }

        public async Task InsertHotels(List<Hotel> hotels)
        {
            await _hotelCollection.InsertHotels(hotels);
        }

        public async Task<Hotel> GetHotel(string id)
        {
            return await _hotelCollection.GetHotel(id);
        }

        public async Task<List<Hotel>> GetHotels(int locationId)
        {
            return await _hotelCollection.GetHotels(locationId);
        }

    }
}
