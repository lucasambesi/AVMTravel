using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities.Enums;

namespace AVMTravel.Tours.API.Domain.Interfaces.Services
{
    public interface IReservationService
    {
        Task<bool> InsertAsync(ReservationDto reservationDto);

        Task<bool> UpdateStatusAsync(ReservationDto reservationDto, EReservationStatus status);

        Task<ReservationDto?> GetByIdAsync(int id, bool includeRelatedEntities = true);
    }
}
