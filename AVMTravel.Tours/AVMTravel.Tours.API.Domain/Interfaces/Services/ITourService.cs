using AVMTravel.Tours.API.Domain.DTOs;

namespace AVMTravel.Tours.API.Domain.Interfaces.Services
{
    public interface ITourService
    {
        Task<TourDto?> GetByIdAsync(int id);
    }
}
