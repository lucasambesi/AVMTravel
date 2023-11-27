using AVMTravel.Tours.API.Domain.DTOs;

namespace AVMTravel.Tours.API.Domain.Interfaces.Queries
{
    public interface IReservationQuery
    {
        Task<ReservationDto?> GetByIdAsync(int id, bool includeRelatedEntities = true);
    }
}
