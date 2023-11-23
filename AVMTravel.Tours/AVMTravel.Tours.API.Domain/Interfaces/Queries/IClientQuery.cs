using AVMTravel.Tours.API.Domain.DTOs;

namespace AVMTravel.Tours.API.Domain.Interfaces.Queries
{
    public interface IClientQuery
    {
        Task<ClientDto?> GetByIdAsync(int id);
    }
}
