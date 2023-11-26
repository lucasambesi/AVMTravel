using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Update;
using AVMTravel.Tours.API.Domain.Helpers;
using FluentValidation;

namespace AVMTravel.Tours.API.Application.Validators.Tour
{
    public class UpdateTourValidator : AbstractValidator<UpdateTourRequest>
    {
        public UpdateTourValidator()
        {
            MandatoryValidations();
        }

        private void MandatoryValidations()
        {
            RuleFor(request => request.Id)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(UpdateTourRequest.Id)));

            RuleFor(request => request.Name)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(UpdateTourRequest.Name)));

            RuleFor(request => request.Description)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(UpdateTourRequest.Description)));

            RuleFor(request => request.StartDate)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(UpdateTourRequest.StartDate)));

            RuleFor(request => request.DurationHours)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(UpdateTourRequest.DurationHours)));

            RuleFor(request => request.Price)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(UpdateTourRequest.Price)));

            RuleFor(request => request.LocationId)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(UpdateTourRequest.LocationId)));

            RuleFor(request => request.TourGuide)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(UpdateTourRequest.TourGuide)));

            RuleFor(request => request.DifficultyLevel)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(UpdateTourRequest.DifficultyLevel)));
        }
    }
}