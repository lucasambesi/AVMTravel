using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Application.Mappings
{
    public class TourMappings : Profile
    {
        public TourMappings()
        {
            #region Entities
                CreateMap<TourDto, Tour>();
            #endregion

            #region Dtos
                CreateMap<Tour, TourDto>();
            #endregion

            #region Request
            #endregion

            #region Results
            #endregion
        }
    }
}
