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
        }
    }
}
