using AutoMapper;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Persistence.Contexts;

namespace AVMTravel.Tours.API.Persistence.Percistence.Command
{
    public class ClientRepository : IClientRepository
    {
        private readonly BaseContext _dbContext;

        private readonly IMapper _mapper;

        public ClientRepository(
            BaseContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<bool> InsertAsync(Client client)
        {
            _dbContext.Clients.Add(client);

            var result = await _dbContext.SaveChangesAsync();

            return result > 0;
        }
    }
}
