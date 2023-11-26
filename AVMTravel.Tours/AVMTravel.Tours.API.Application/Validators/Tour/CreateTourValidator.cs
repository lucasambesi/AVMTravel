using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Create;
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
                .WithMessage("The Name cannot be empty");

            RuleFor(request => request.LocationId)
                .NotEmpty()
                .WithMessage("The Location id cannot be empty");

            RuleFor(request => request.DurationHours)
                .NotEmpty()
                .WithMessage("The DurationHours cannot be empty");

            RuleFor(request => request.DifficultyLevel)
                .NotEmpty()
                .WithMessage("The DifficultyLevel cannot be empty");

            RuleFor(request => request.StartDate)
                .NotEmpty()
                .WithMessage("The StartDate cannot be empty");

            RuleFor(request => request.Price)
                .NotEmpty()
                .WithMessage("The Price cannot be empty");
        }
    }
}
