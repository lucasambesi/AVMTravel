﻿using AutoMapper;
using AVMTravel.Tours.API.Application.Services;
using AVMTravel.Tours.API.Application.UseCases.Tours.V1.GetById;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;
using AVMTravel.Tours.API.Domain.Constants;

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
                throw new ApplicationApiException(ExceptionConstants.ENTITY_NOT_FOUND, EErrorCodeType.NotFound);
            }

            var result = _mapper.Map<GetByIdReservationResult>(reservation);

            return result;
        }
    }
}
