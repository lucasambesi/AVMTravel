using AutoMapper;
using AVMTravel.Tours.API.Application.Services;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.Create
{
    public class CreateHandler : IRequestHandler<CreateTourRequest, CreateTourResult>
    {
        private readonly ITourService _tourService;

        private readonly IMapper _mapper;

        public CreateHandler(
            ITourService tourService,
            IMapper mapper)
        {
            _tourService = tourService;
            _mapper = mapper;
        }

        public async Task<CreateTourResult> Handle(CreateTourRequest request, CancellationToken cancellationToken)
        {
            var tour = _mapper.Map<TourDto>(request);

            var result = await _tourService.InsertAsync(tour);

            return new CreateTourResult(result);
        }
    }
}
