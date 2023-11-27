using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AVMTravel.Tours.API.Persistence.Percistence.Query
{
    public class LocationQuery : ILocationQuery
    {

        private readonly BaseContext _dbContext;

        private readonly IMapper _mapper;

        public LocationQuery(
            BaseContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<LocationDto>> GetAllAsync()
        {
            var locations = await _dbContext.Locations.ToListAsync();

            var result = _mapper.Map<List<LocationDto>>(locations);

            return result;
        }

        public async Task<LocationDto?> GetByIdAsync(int id)
        {
            var location = await _dbContext.Locations.FirstOrDefaultAsync(l => l.Id == id);

            var result = _mapper.Map<LocationDto>(location);

            return result;
        }
    }
}
