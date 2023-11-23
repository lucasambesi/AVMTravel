using AVMTravel.Tours.API.Domain.DTOs;
namespace AVMTravel.Tours.API.Domain.Interfaces.Services
{
    public interface ITourService
    {
        Task<bool> InsertAsync(TourDto tourDto);

        Task<bool> UpdateAsync(TourDto existingTour, TourDto newTour);

        Task<TourDto?> GetByIdAsync(int id);
    }
}
