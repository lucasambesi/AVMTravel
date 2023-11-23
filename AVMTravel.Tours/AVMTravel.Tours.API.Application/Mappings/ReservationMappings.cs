using AutoMapper;
using AVMTravel.Tours.API.Application.UseCases.Client.V1.Register;
using AVMTravel.Tours.API.Application.UseCases.Reservation.V1.Create;
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
            CreateMap<CreateReservationRequest, ReservationDto>();
            #endregion

            #region Results
            #endregion
        }
    }
}
