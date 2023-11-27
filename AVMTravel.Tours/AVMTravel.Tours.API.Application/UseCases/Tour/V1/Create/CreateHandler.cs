using AutoMapper;
using AVMTravel.Tours.API.Application.Validators.Reservation;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using FluentValidation;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.Create
{
    public class CreateHandler : IRequestHandler<CreateTourRequest, CreateTourResult>
    {
        private readonly ITourService _tourService;

        private readonly IMapper _mapper;

        private readonly IValidator<CreateTourRequest> _createTourValidator;

        public CreateHandler(
            ITourService tourService,
            IMapper mapper,
            IValidator<CreateTourRequest> createTourValidator)
        {
            _tourService = tourService;
            _mapper = mapper;
            _createTourValidator = createTourValidator;
        }

        public async Task<CreateTourResult> Handle(CreateTourRequest request, CancellationToken cancellationToken)
        {
            var validationResult = _createTourValidator.Validate(request);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ValidationApiException(errors);
            }

            var tour = _mapper.Map<TourDto>(request);

            var result = await _tourService.InsertAsync(tour);

            return new CreateTourResult(result);
        }
    }
}
