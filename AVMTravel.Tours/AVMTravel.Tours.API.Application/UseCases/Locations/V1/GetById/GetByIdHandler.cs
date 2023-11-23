using AutoMapper;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById
{
    public class GetByIdHandler : IRequestHandler<GetByIdLocationRequest, GetByIdLocationResult>
    {
        private readonly ILocationService _locationService;

        private readonly IMapper _mapper;

        public GetByIdHandler(ILocationService locationService, IMapper mapper)
        {
            _locationService = locationService;
            _mapper = mapper;
        }

        public async Task<GetByIdLocationResult> Handle(
            GetByIdLocationRequest request,
            CancellationToken cancellationToken)
        {
            var location = await _locationService.GetByIdAsync(request.Id);

            if (location == null)
            {
                throw new Exception("Entity not found");
            }

            var result = _mapper.Map<GetByIdLocationResult>(location);

            return result;
        }
    }
}
