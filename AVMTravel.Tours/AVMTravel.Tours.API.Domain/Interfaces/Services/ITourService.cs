using AVMTravel.Tours.API.Domain.DTOs;

namespace AVMTravel.Tours.API.Domain.Interfaces.Services
{
    public interface ITourService
    {
        Task<bool> InsertAsync(TourDto tourDto);

        Task<TourDto?> GetByIdAsync(int id);
    }
}
