using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Persistence.Mappings
{
    public class MappingLocationTest : Profile
    {
        public MappingLocationTest()
        {
            #region Entities
            CreateMap<LocationDto, Location>();
            #endregion

            #region Dtos
            CreateMap<Location, LocationDto>();
            #endregion
        }
    }
}
