using AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create;
using FluentValidation;

namespace AVMTravel.Tours.API.Application.Validators.Location
{
    public class CreateLocationValidator : AbstractValidator<CreateLocationRequest>
    {
        public CreateLocationValidator()
        {
            MandatoryValidations();
        }

        private void MandatoryValidations()
        {
            RuleFor(request => request.Name)
                .NotEmpty()
                .WithMessage("The name cannot be empty");
        }
    }
}
