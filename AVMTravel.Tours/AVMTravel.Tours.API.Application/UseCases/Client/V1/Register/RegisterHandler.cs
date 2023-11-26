using AutoMapper;
using AVMTravel.Tours.API.Application.UseCases.Client.V1.Login;
using AVMTravel.Tours.API.Application.Validators.Client;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using FluentValidation;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Client.V1.Register
{
    public class RegisterHandler : IRequestHandler<RegisterRequest, RegisterResult>
    {
        private readonly IClientService _clientService;

        private readonly IMapper _mapper;

        private readonly IValidator<RegisterRequest> _registerValidator;

        public RegisterHandler(
            IClientService clientService,
            IMapper mapper,
            IValidator<RegisterRequest> registerValidator)
        {
            _clientService = clientService;
            _mapper = mapper;
            _registerValidator = registerValidator;
        }

        public async Task<RegisterResult> Handle(
        RegisterRequest request,
            CancellationToken cancellationToken)
        {
            var validationResult = _registerValidator.Validate(request);

            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ValidationApiException(errors);
            }

            var client = _mapper.Map<ClientDto>(request);

            var exists = await _clientService.GetByEmailAsync(request.Email);

            if (exists != null)
            {
                throw new ApplicationApiException("The email has already been registered", EErrorCodeType.Business);
            }

            var result = await _clientService.RegisterAsync(client);

            return new RegisterResult(result);
        }
    }
}
