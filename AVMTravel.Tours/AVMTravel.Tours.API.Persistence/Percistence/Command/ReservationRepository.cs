using AutoMapper;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Persistence.Contexts;

namespace AVMTravel.Tours.API.Persistence.Percistence.Command
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly BaseContext _dbContext;

        public ReservationRepository(
            BaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> InsertAsync(Reservation reservation)
        {
            try
            {            
                _dbContext.Reservations.Add(reservation);

                var result = await _dbContext.SaveChangesAsync();

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new PercistenceApiException(ex.Message, EErrorCodeType.InternalError);
            }
        }
    }
}
