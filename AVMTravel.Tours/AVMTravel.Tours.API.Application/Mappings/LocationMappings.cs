using AutoMapper;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Application.Mappings
{
    public class LocationMappings : Profile
    {
        public LocationMappings()
        {
            #region Entities
                CreateMap<LocationDto, Location>();
            #endregion

            #region Dtos
                CreateMap<Location, LocationDto>();
            #endregion

            #region Results
                CreateMap<LocationDto, GetByIdLocationResult>();
            #endregion
        }
    }
}
