﻿using AutoMapper;
using AVMTravel.Tours.API.Domain.Constants;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Client.V1.GetById
{
    public class GetByIdHandler : IRequestHandler<GetByIdClientRequest, GetByIdClientResult>
    {
        private readonly IClientService _clientService;

        private readonly IMapper _mapper;

        public GetByIdHandler(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public async Task<GetByIdClientResult> Handle(
            GetByIdClientRequest request,
            CancellationToken cancellationToken)
        {
            var client = await _clientService.GetByIdAsync(request.Id);

            if (client == null)
            {
                throw new ApplicationApiException(ExceptionConstants.ENTITY_NOT_FOUND, EErrorCodeType.NotFound);
            }

            var result = _mapper.Map<GetByIdClientResult>(client);

            return result;
        }
    }
}
