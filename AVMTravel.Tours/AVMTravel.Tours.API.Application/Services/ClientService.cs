using AutoMapper;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Domain.Interfaces.Services;

namespace AVMTravel.Tours.API.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientQuery _clientQuery;
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientService(
            IClientQuery clientQuery,
            IClientRepository clientRepository,
            IMapper mapper)
        {
            _clientQuery = clientQuery;
            _clientRepository = clientRepository;
            _mapper = mapper;
        }
    }
}
