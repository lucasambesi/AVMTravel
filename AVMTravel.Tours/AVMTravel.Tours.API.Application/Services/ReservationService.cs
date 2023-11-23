using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Entities.Enums;
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

        public async Task<bool> InsertAsync(ReservationDto reservationDto)
        {
            var reservation = _mapper.Map<Reservation>(reservationDto);

            FillEntity(reservation);

            return await _reservationRepository.InsertAsync(reservation);
        }

        private static void FillEntity(Reservation reservation)
        {
            reservation.Status = EReservationStatus.Created;
        }

        public async Task<ReservationDto?> GetByIdAsync(int id)
        {
            return await _reservationQuery.GetByIdAsync(id);
        }
    }
}
