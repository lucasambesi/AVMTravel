using AVMTravel.Tours.API.Application.UseCases.Client.V1.Login;
using AVMTravel.Tours.API.Domain.Helpers;
using Azure.Core;
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
            .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(LoginRequest.Email)));

            RuleFor(request => request.Password)
                .NotEmpty()
                .WithMessage(CommonHelper.CannotBeEmptyMessage(nameof(LoginRequest.Password)));
        }
    }
}
