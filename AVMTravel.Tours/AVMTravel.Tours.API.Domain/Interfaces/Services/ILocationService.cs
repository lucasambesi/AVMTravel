using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Domain.Interfaces.Services
{
    public interface ILocationService
    {
        Task<bool> InsertAsync(LocationDto locationDto);

        Task<List<LocationDto>> GetAllAsync();

        Task<LocationDto?> GetByIdAsync(int id);
    }
}
