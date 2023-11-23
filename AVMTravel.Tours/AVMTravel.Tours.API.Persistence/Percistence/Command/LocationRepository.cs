using AutoMapper;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Persistence.Contexts;

namespace AVMTravel.Tours.API.Persistence.Percistence.Command
{
    public class LocationRepository : ILocationRepository
    {
        private readonly BaseContext _dbContext;

        private readonly IMapper _mapper;

        public LocationRepository(
            BaseContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<bool> InsertAsync(Location location)
        {
            _dbContext.Locations.Add(location);

            var result = await _dbContext.SaveChangesAsync();

            return result > 0;
        }
    }
}
