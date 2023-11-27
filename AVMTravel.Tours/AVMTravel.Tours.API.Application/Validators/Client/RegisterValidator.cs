using AVMTravel.Tours.API.Application.UseCases.Client.V1.Register;
using AVMTravel.Tours.API.Domain.Helpers;
using FluentValidation;


namespace AVMTravel.Tours.API.Application.Validators.Client
{
    public class RegisterValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterValidator()
        {
            MandatoryValidations();
        }

        private void MandatoryValidations()
        {
            RuleFor(request => request.FullName)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(RegisterRequest.FullName)));

            RuleFor(request => request.Email)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(RegisterRequest.Email)));

            RuleFor(request => request.Password)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(RegisterRequest.Password)));            
        }
    }
}
