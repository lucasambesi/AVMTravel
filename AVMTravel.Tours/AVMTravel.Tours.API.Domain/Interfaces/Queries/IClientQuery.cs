using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Domain.Interfaces.Queries
{
    public interface IClientQuery
    {
        Task<ClientDto?> GetByIdAsync(int id);

        Task<ClientDto?> GetByEmailAsync(string email);

        Task<ClientDto?> GetUserByCredentialsAsync(Client client);
    }
}
