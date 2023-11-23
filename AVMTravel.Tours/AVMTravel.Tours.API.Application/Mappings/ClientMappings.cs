using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Application.Mappings
{
    public class ClientMappings : Profile
    {
        public ClientMappings()
        {
            #region Entities
            CreateMap<ClientDto, Client>();
            #endregion

            #region Dtos
            CreateMap<Client, ClientDto>();
            #endregion

            #region Request
            #endregion

            #region Results
            #endregion
        }
    }
}
