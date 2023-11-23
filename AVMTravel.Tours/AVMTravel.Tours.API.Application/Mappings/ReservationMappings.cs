using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;

namespace AVMTravel.Tours.API.Application.Mappings
{
    public class ReservationMappings : Profile
    {
        public ReservationMappings()
        {
            #region Entities
            CreateMap<ReservationDto, Reservation>();
            #endregion

            #region Dtos
            CreateMap<Reservation, ReservationDto>();
            #endregion

            #region Request
            #endregion

            #region Results
            #endregion
        }
    }
}
