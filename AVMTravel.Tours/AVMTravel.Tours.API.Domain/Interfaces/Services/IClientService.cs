using AVMTravel.Tours.API.Domain.DTOs;

namespace AVMTravel.Tours.API.Domain.Interfaces.Services
{
    public interface IClientService
    {
        Task<bool> RegisterAsync(ClientDto clientDto);

        Task<bool> InsertAsync(ClientDto clientDto);

        Task<ClientDto?> GetByIdAsync(int id);
    }
}
