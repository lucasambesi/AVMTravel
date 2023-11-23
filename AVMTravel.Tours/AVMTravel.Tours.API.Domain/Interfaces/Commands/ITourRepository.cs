using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Domain.Interfaces.Commands
{
    public interface ITourRepository
    {
        Task<bool> InsertAsync(Tour tour);
    }
}
