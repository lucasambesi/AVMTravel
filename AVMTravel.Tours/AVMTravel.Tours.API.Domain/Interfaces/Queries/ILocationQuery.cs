using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Domain.Interfaces.Queries
{
    public interface ILocationQuery
    {
        Task<List<LocationDto>> GetAllAsync();

        Task<LocationDto?> GetByIdAsync(int id);
    }
}
