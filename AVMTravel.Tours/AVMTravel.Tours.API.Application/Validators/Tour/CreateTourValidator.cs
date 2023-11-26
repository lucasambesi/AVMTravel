using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Create;
using AVMTravel.Tours.API.Domain.Helpers;
using Azure.Core;
using FluentValidation;


namespace AVMTravel.Tours.API.Application.Validators.Tour
{
    public class CreateTourValidator : AbstractValidator<CreateTourRequest>
    {
        public CreateTourValidator()
        {
            MandatoryValidations();
        }

        private void MandatoryValidations()
        {
            RuleFor(request => request.Name)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(CreateTourRequest.Name)));

            RuleFor(request => request.LocationId)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(CreateTourRequest.LocationId)));

            RuleFor(request => request.DurationHours)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(CreateTourRequest.DurationHours)));

            RuleFor(request => request.DifficultyLevel)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(CreateTourRequest.DifficultyLevel)));

            RuleFor(request => request.StartDate)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(CreateTourRequest.StartDate)));

            RuleFor(request => request.Price)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(CreateTourRequest.Price)));
        }
    }
}
