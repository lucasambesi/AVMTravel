using AutoMapper;
using AVMTravel.Tours.API.Application.Services;
using AVMTravel.Tours.API.Application.UseCases.Tours.V1.GetById;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Reservation.V1.GetById
{
    public class GetByIdHandler : IRequestHandler<GetByIdReservationRequest, GetByIdReservationResult>
    {
        private readonly IReservationService _reservationService;

        private readonly IMapper _mapper;

        public GetByIdHandler(IReservationService reservationService, IMapper mapper)
        {
            _reservationService = reservationService;
            _mapper = mapper;
        }

        public async Task<GetByIdReservationResult> Handle(GetByIdReservationRequest request, CancellationToken cancellationToken)
        {
            var reservation = await _reservationService.GetByIdAsync(request.Id);

            if (reservation == null)
            {
                throw new Exception("Entity not found");
            }

            var result = _mapper.Map<GetByIdReservationResult>(reservation);

            return result;
        }
    }
}
