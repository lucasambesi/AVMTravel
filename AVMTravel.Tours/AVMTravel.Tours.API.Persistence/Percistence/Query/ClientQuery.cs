using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AVMTravel.Tours.API.Persistence.Percistence.Query
{
    public class ClientQuery : IClientQuery
    {
        private readonly BaseContext _dbContext;

        private readonly IMapper _mapper;

        public ClientQuery(
            BaseContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ClientDto?> GetByIdAsync(int id)
        {
            var location = await _dbContext.Clients.FirstOrDefaultAsync(l => l.Id == id);

            var result = _mapper.Map<ClientDto>(location);

            return result;
        }

        public async Task<ClientDto?> GetUserByCredentialsAsync(Client client)
        {
            var query = await _dbContext.Clients.FirstOrDefaultAsync(
                l => l.Email == client.Email &&
                l.Password == client.Password);

            var result = _mapper.Map<ClientDto>(query);

            return result;
        }
    }
}
