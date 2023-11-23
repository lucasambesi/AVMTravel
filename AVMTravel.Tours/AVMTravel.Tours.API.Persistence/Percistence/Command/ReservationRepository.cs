using AutoMapper;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Persistence.Contexts;

namespace AVMTravel.Tours.API.Persistence.Percistence.Command
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly BaseContext _dbContext;

        private readonly IMapper _mapper;

        public ReservationRepository(
            BaseContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<bool> InsertAsync(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);

            var result = await _dbContext.SaveChangesAsync();

            return result > 0;
        }
    }
}
