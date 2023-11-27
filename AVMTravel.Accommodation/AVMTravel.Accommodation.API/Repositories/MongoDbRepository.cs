using MongoDB.Driver;

namespace AVMTravel.Accommodation.API.Repositories
{
    public class MongoDbRepository
    {
        public MongoClient client;

        public IMongoDatabase database;

        public MongoDbRepository()
        {
            client = new MongoClient("mongodb://127.0.0.1:27017");
            database = client.GetDatabase("AVMTravel-Accommodation");
        }
    }
}
