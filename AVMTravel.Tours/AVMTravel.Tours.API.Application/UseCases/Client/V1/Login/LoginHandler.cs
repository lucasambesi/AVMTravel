using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Client.V1.Login
{
    public class LoginHandler : IRequestHandler<LoginRequest, LoginResult>
    {
        private readonly IClientService _clientService;

        private readonly IMapper _mapper;

        public LoginHandler(
            IClientService clientService,
            IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public async Task<LoginResult> Handle(
            LoginRequest request,
            CancellationToken cancellationToken)
        {
            var clientDto = _mapper.Map<ClientDto>(request);

            clientDto = await _clientService.GetUserByCredentialsAsync(clientDto);

            if (clientDto == null)
            {
                throw new ApplicationApiException("Email or password not found", EErrorCodeType.Business);                
            }

            var token = _clientService.GenerateToken(clientDto);

            return new LoginResult(token);
        }
    }
}
