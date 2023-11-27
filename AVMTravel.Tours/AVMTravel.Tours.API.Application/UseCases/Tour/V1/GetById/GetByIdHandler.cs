using AutoMapper;
using AVMTravel.Tours.API.Domain.Constants;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.GetById
{
    public class GetByIdHandler : IRequestHandler<GetByIdTourRequest, GetByIdTourResult>
    {

        private readonly ITourService _tourService;

        private readonly IMapper _mapper;

        public GetByIdHandler(ITourService tourService, IMapper mapper)
        {
            _tourService = tourService;
            _mapper = mapper;
        }

        public async Task<GetByIdTourResult> Handle(GetByIdTourRequest request, CancellationToken cancellationToken)
        {
            var tour = await _tourService.GetByIdAsync(request.Id);

            if (tour == null)
            {
                throw new ApplicationApiException(ExceptionConstants.ENTITY_NOT_FOUND, EErrorCodeType.NotFound);
            }

            var result = _mapper.Map<GetByIdTourResult>(tour);

            return result;
        }
    }
}
