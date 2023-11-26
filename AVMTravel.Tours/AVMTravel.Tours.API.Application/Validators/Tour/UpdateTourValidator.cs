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
                .WithMessage("The id cannot be empty");

            RuleFor(request => request.Name)
                .NotEmpty()
                .WithMessage("The Name cannot be empty");

            RuleFor(request => request.Description)
                .NotEmpty()
                .WithMessage("The Description cannot be empty");

            RuleFor(request => request.StartDate)
                .NotEmpty()
                .WithMessage("The StartDate cannot be empty");

            RuleFor(request => request.DurationHours)
            .NotEmpty()
            .WithMessage("The DurationHours cannot be empty");

            RuleFor(request => request.Price)
            .NotEmpty()
            .WithMessage("The Price cannot be empty");

            RuleFor(request => request.LocationId)
            .NotEmpty()
            .WithMessage("The LocationId cannot be empty");

            RuleFor(request => request.TourGuide)
            .NotEmpty()
            .WithMessage("The TourGuide cannot be empty");

            RuleFor(request => request.DifficultyLevel)
            .NotEmpty()
            .WithMessage("The DifficultyLevel cannot be empty");
        }
    }
}