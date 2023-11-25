using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Domain.Interfaces.Commands
{
    public interface ILocationRepository
    {
        Task<int> InsertAsync(Location location);
    }
}
