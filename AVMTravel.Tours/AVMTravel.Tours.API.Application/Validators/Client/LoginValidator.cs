using AVMTravel.Tours.API.Application.UseCases.Client.V1.Login;
using FluentValidation;

namespace AVMTravel.Tours.API.Application.Validators.Client
{
    public class LoginValidator : AbstractValidator<LoginRequest>
    {
        public LoginValidator()
        {
            MandatoryValidations();
        }

        private void MandatoryValidations()
        {
            RuleFor(request => request.Email)
                .NotEmpty()
                .WithMessage("The email cannot be empty");

            RuleFor(request => request.Password)
                .NotEmpty()
                .WithMessage("The password cannot be empty");
        }
    }
}
