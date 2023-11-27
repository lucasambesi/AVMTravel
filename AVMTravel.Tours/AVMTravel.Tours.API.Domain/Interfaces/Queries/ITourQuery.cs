using AVMTravel.Tours.API.Domain.DTOs;

namespace AVMTravel.Tours.API.Domain.Interfaces.Queries
{
    public interface ITourQuery
    {
        Task<TourDto?> GetByIdAsync(int id);
    }
}
