using AutoMapper;
using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Create;
using AVMTravel.Tours.API.Application.Validators.Tour;
using AVMTravel.Tours.API.Domain.Constants;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using FluentValidation;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.Update
{
    public class UpdateHandler : IRequestHandler<UpdateTourRequest, UpdateTourResult>
    {
        private readonly ITourService _tourService;

        private readonly IMapper _mapper;

        private readonly IValidator<UpdateTourRequest> _updateTourValidator;

        public UpdateHandler(
            ITourService tourService,
            IMapper mapper,
            IValidator<UpdateTourRequest> updateTourValidator)
        {
            _tourService = tourService;
            _mapper = mapper;
            _updateTourValidator = updateTourValidator;
        }

        public async Task<UpdateTourResult> Handle(
            UpdateTourRequest request,
            CancellationToken cancellationToken)
        {
            var validationResult = _updateTourValidator.Validate(request);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ValidationApiException(errors);
            }

            var tour = await _tourService.GetByIdAsync(request.Id);

            if (tour == null)
            {
                throw new ApplicationApiException(ExceptionConstants.ENTITY_NOT_FOUND, EErrorCodeType.NotFound);
            }

            var newTour = _mapper.Map<TourDto>(request);

            var result = await _tourService.UpdateAsync(tour, newTour);

            return new UpdateTourResult(result);
        }
    }
}
