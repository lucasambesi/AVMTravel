using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using FluentValidation;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Reservation.V1.Create
{
    public class CreateHandler : IRequestHandler<CreateReservationRequest, CreateReservationResult>
    {
        private readonly IReservationService _reservationService;

        private readonly IClientService _clientService;

        private readonly ITourService _tourService;

        private readonly IMapper _mapper;

        private readonly IValidator<CreateReservationRequest> _createReservationValidator;

        public CreateHandler(
            IReservationService reservationService,
            IClientService clientService,
            ITourService tourService,
            IMapper mapper,
            IValidator<CreateReservationRequest> createReservationValidator)
        {
            _reservationService = reservationService;
            _clientService = clientService;
            _tourService = tourService;
            _mapper = mapper;
            _createReservationValidator = createReservationValidator;
        }

        public async Task<CreateReservationResult> Handle(
            CreateReservationRequest request,
            CancellationToken cancellationToken)
        {
            var validationResult = _createReservationValidator.Validate(request);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ValidationApiException(errors);
            }

            var reservation = _mapper.Map<ReservationDto>(request);

            var client = await _clientService.GetByIdAsync(reservation.ClientId);

            if (client == null)
            {
                throw new ApplicationApiException("Client not found", EErrorCodeType.NotFound);
            }

            var tour = await _tourService.GetByIdAsync(reservation.TourId);

            if (tour == null)
            {
                throw new ApplicationApiException("Tour not found", EErrorCodeType.NotFound);
            }

            var result = await _reservationService.InsertAsync(reservation);

            return new CreateReservationResult(result);
        }
    }
}
