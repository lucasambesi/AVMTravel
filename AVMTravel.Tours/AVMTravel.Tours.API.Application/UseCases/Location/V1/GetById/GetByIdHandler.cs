using AutoMapper;
using AVMTravel.Tours.API.ApiClients;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById
{
    public class GetByIdHandler : IRequestHandler<GetByIdLocationRequest, GetByIdLocationResult>
    {
        private readonly ILocationService _locationService;

        private readonly IMapper _mapper;

        private readonly IAccommodationServiceClient _accommodationServiceClient;

        public GetByIdHandler(
            ILocationService locationService, 
            IMapper mapper, 
            IAccommodationServiceClient accommodationServiceClient)
        {
            _locationService = locationService;
            _mapper = mapper;
            _accommodationServiceClient = accommodationServiceClient;
        }

        public async Task<GetByIdLocationResult> Handle(
            GetByIdLocationRequest request,
            CancellationToken cancellationToken)
        {
            var location = await _locationService.GetByIdAsync(request.Id);

            if (location == null)
            {
                throw new ApplicationApiException("Entity not found", EErrorCodeType.NotFound);
            }

            var result = _mapper.Map<GetByIdLocationResult>(location);

            try
            {
                var hotels = await _accommodationServiceClient.GetHotelByLocationIdAsync(location.Id);

                if (hotels != null)
                {
                    result.Hotels = hotels.ToList();
                }
            }
            catch
            {
                result.Hotels = null;
            }
           
            return result;
        }
    }
}
