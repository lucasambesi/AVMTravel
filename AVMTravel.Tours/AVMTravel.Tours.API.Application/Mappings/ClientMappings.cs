using AutoMapper;
using AVMTravel.Tours.API.Application.UseCases.Client.V1.GetById;
using AVMTravel.Tours.API.Application.UseCases.Client.V1.Register;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById;
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
            CreateMap<RegisterRequest, ClientDto>();
            #endregion

            #region Results
            CreateMap<ClientDto, GetByIdClientResult>();
            #endregion
        }
    }
}
