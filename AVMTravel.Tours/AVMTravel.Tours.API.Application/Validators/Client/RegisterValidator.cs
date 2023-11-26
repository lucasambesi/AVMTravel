﻿using AVMTravel.Tours.API.Application.UseCases.Client.V1.Register;
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
                .WithMessage("The full name cannot be empty");

            RuleFor(request => request.Email)
                .NotEmpty()
                .WithMessage("The email cannot be empty");

            RuleFor(request => request.Password)
                .NotEmpty()
                .WithMessage("The password cannot be empty");
        }
    }
}
