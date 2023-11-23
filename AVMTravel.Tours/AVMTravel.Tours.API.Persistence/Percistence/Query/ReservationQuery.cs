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
            var location = await _dbContext.Locations.FirstOrDefaultAsync(l => l.Id == id);

            var result = _mapper.Map<ReservationDto>(location);

            return result;
        }
    }
}
