using AutoMapper;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Persistence.Contexts;

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
    }
}
