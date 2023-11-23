using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Domain.Interfaces.Commands
{
    public interface ILocationRepository
    {
        Task<bool> InsertAsync(Location location);
    }
}
