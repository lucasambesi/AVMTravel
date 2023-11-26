using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using AVMTravel.Tours.API.Domain.Helpers.Encrypt;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AVMTravel.Tours.API.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientQuery _clientQuery;
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;

        public ClientService(
            IClientQuery clientQuery,
            IClientRepository clientRepository,
            IMapper mapper,
            IConfiguration config)
        {
            _clientQuery = clientQuery;
            _clientRepository = clientRepository;
            _mapper = mapper;
            _config = config;
        }


        public async Task<bool> RegisterAsync(ClientDto clientDto)
        {
            if (string.IsNullOrEmpty(clientDto.Password) ||
                string.IsNullOrEmpty(clientDto.Email))
            {
                throw new ApplicationApiException("Email or password empty", EErrorCodeType.Business );
            }

            clientDto.Password = EncryptPassword(clientDto.Password);

            return await InsertAsync(clientDto);
        }

        public async Task<ClientDto?> GetUserByCredentialsAsync(ClientDto clientDto)
        {
            clientDto.Password = EncryptPassword(clientDto.Password);

            var client = _mapper.Map<Client>(clientDto);

            return await _clientQuery.GetUserByCredentialsAsync(client);
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

        public async Task<ClientDto?> GetByEmailAsync(string email)
        {
            return await _clientQuery.GetByEmailAsync(email);
        }

        private string EncryptPassword(string password)
        {
            return Encrypt.GetSHA256(password);
        }

        public string GenerateToken(ClientDto clientDto)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, clientDto.Email),
                new Claim(ClaimTypes.NameIdentifier, clientDto.Id.ToString()),
            };

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddHours(12),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
