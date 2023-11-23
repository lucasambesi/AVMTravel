using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Client.V1.Register
{
    public class RegisterHandler : IRequestHandler<RegisterRequest, RegisterResult>
    {
        private readonly IClientService _clientService;

        private readonly IMapper _mapper;

        public RegisterHandler(
            IClientService clientService,
            IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public async Task<RegisterResult> Handle(
            RegisterRequest request,
            CancellationToken cancellationToken)
        {
            var client = _mapper.Map<ClientDto>(request);

            var result = await _clientService.RegisterAsync(client);

            return new RegisterResult(result);
        }
    }
}
