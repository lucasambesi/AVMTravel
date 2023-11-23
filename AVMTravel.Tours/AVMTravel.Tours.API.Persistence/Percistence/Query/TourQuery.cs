using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AVMTravel.Tours.API.Persistence.Percistence.Query
{
    public class TourQuery : ITourQuery
    {
        private readonly BaseContext _dbContext;

        private readonly IMapper _mapper;

        public TourQuery(
            BaseContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<TourDto?> GetByIdAsync(int id)
        {
            var tour = await _dbContext.Tours.FirstOrDefaultAsync(l => l.Id == id);

            var result = _mapper.Map<TourDto>(tour);

            return result;
        }
    }
}
