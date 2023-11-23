using AutoMapper;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Domain.Interfaces.Services;

namespace AVMTravel.Tours.API.Application.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationQuery _reservationQuery;
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public ReservationService(
            IReservationQuery reservationQuery,
            IReservationRepository reservationRepository,
            IMapper mapper)
        {
            _reservationQuery = reservationQuery;
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }
    }
}
