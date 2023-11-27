using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace AVMTravel.Accommodation.API.Models
{
    public class Hotel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string? HotelId { get; set; }

        public int LocationId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public double Rating { get; set; }
    }
}
