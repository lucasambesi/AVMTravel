using AVMTravel.Tours.API.Domain.DTOs;

namespace AVMTravel.Tours.API.Domain.Interfaces.Services
{
    public interface IReservationService
    {
        Task<bool> InsertAsync(ReservationDto reservationDto);

        Task<ReservationDto?> GetByIdAsync(int id);
    }
}
