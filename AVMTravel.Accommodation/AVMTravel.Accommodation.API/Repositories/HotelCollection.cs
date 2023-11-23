using AVMTravel.Accommodation.API.Models;
using AVMTravel.Accommodation.API.Repositories.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AVMTravel.Accommodation.API.Repositories
{
    public class HotelCollection : IHotelCollection
    {
        internal MongoDbRepository _repository = new MongoDbRepository();
        private IMongoCollection<Hotel> Collection;

        public HotelCollection()
        {
            Collection = _repository.database.GetCollection<Hotel>("Hotels");
        }

        public async Task InsertHotel(Hotel hotel)
        {
            await Collection.InsertOneAsync(hotel);
        }

        public async Task InsertHotels(List<Hotel> hotels)
        {
            await Collection.InsertManyAsync(hotels);
        }

        public async Task<Hotel> GetHotel(string id)
        {
            return await Collection.FindAsync(
                new BsonDocument { { "_id", new ObjectId(id) } }).Result.FirstAsync();
        }

        public async Task<List<Hotel>> GetHotels(int locationId)
        {
            var hotels = await Collection.FindAsync(
                new BsonDocument { { "LocationId", locationId } }).Result.ToListAsync();

            foreach (var hotel in hotels)
            {
                hotel.HotelId = hotel.Id.ToString();
            }

            return hotels;
        }
    }
}
