using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Domain.Interfaces.Commands
{
    public interface IClientRepository
    {
        Task<bool> InsertAsync(Client client);
    }
}
