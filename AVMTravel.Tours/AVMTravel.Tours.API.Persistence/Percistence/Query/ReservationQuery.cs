using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AVMTravel.Tours.API.Persistence.Percistence.Query
{
    public class ReservationQuery : IReservationQuery
    {
        private readonly BaseContext _dbContext;

        private readonly IMapper _mapper;

        public ReservationQuery(
            BaseContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ReservationDto?> GetByIdAsync(int id)
        {
            var reservation = await _dbContext.Reservations
                .Include(r => r.Client)
                .Include(r => r.Tour)
                .Where(l => l.Id == id)
                .FirstOrDefaultAsync();

            var result = _mapper.Map<ReservationDto>(reservation);

            return result;
        }
    }
}
