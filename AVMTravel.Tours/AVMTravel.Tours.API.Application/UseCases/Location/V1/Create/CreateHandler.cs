using AutoMapper;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using FluentValidation;
using MediatR;
using System;

namespace AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create
{
    public class CreateHandler : IRequestHandler<CreateLocationRequest, CreateLocationResult>
    {
        private readonly ILocationService _locationService;
        private readonly IValidator<CreateLocationRequest> _locationValidator;
        private readonly IMapper _mapper;

        public CreateHandler(
            ILocationService locationService,
            IValidator<CreateLocationRequest> locationValidator,
            IMapper mapper)
        {
            _locationService = locationService;
            _locationValidator = locationValidator;
            _mapper = mapper;
        }

        public async Task<CreateLocationResult> Handle(CreateLocationRequest request, CancellationToken cancellationToken)
        {
            var validationResult = _locationValidator.Validate(request);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ValidationApiException(errors);
            }

            var location = _mapper.Map<LocationDto>(request);

            var result = await _locationService.InsertAsync(location);

            return new CreateLocationResult(result > 0, result);
        }
    }
}
