using AutoMapper;
using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Create;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.Update
{
    public class UpdateHandler : IRequestHandler<UpdateTourRequest, UpdateTourResult>
    {
        private readonly ITourService _tourService;

        private readonly IMapper _mapper;

        public UpdateHandler(
            ITourService tourService,
            IMapper mapper)
        {
            _tourService = tourService;
            _mapper = mapper;
        }

        public async Task<UpdateTourResult> Handle(
            UpdateTourRequest request,
            CancellationToken cancellationToken)
        {
            var tour = await _tourService.GetByIdAsync(request.Id);

            if (tour == null)
            {
                throw new ApplicationApiException("Entity not found", EErrorCodeType.NotFound);
            }

            var newTour = _mapper.Map<TourDto>(request);

            var result = await _tourService.UpdateAsync(tour, newTour);

            return new UpdateTourResult(result);
        }
    }
}
