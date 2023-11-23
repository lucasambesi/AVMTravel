using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Domain.Interfaces.Commands
{
    public interface IReservationRepository
    {
        Task<bool> InsertAsync(Reservation reservation);
    }
}
