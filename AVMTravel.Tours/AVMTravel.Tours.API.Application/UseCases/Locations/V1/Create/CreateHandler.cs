using AutoMapper;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create
{
    public class CreateHandler : IRequestHandler<CreateLocationRequest, CreateLocationResult>
    {
        private readonly ILocationService _locationService;

        private readonly IMapper _mapper;

        public CreateHandler(
            ILocationService locationService,
            IMapper mapper)
        {
            _locationService = locationService;
            _mapper = mapper;
        }

        public async Task<CreateLocationResult> Handle(CreateLocationRequest request, CancellationToken cancellationToken)
        {
            var location = _mapper.Map<LocationDto>(request);

            var result = await _locationService.InsertAsync(location);

            return new CreateLocationResult(result);
        }
    }
}
