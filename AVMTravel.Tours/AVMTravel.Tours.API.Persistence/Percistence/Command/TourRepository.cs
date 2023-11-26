using AutoMapper;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Persistence.Contexts;

namespace AVMTravel.Tours.API.Persistence.Percistence.Command
{
    public class TourRepository : ITourRepository
    {
        private readonly BaseContext _dbContext;

        public TourRepository(
            BaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> InsertAsync(Tour tour)
        {
            try
            {
                _dbContext.Tours.Add(tour);

                var result = await _dbContext.SaveChangesAsync();

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new PercistenceApiException(ex.Message, EErrorCodeType.InternalError);
            }
        }

        public async Task<bool> UpdateAsync(Tour tour)
        {
            try
            {           
                _dbContext.Tours.Update(tour);

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
