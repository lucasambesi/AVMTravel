using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Helpers.Encrypt;
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


        public async Task<bool> RegisterAsync(ClientDto clientDto)
        {
            if (string.IsNullOrEmpty(clientDto.Password) ||
                string.IsNullOrEmpty(clientDto.Email))
            {
                throw new Exception("Email or password not found");
            }

            clientDto.Password = EncryptPassword(clientDto.Password);

            return await InsertAsync(clientDto);
        }

        public async Task<bool> InsertAsync(ClientDto clientDto)
        {
            var client = _mapper.Map<Client>(clientDto);

            return await _clientRepository.InsertAsync(client);
        }

        public async Task<ClientDto?> GetByIdAsync(int id)
        {
            return await _clientQuery.GetByIdAsync(id);
        }

        private string EncryptPassword(string password)
        {
            return Encrypt.GetSHA256(password);
        }
    }
}
