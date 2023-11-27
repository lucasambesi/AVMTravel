using AVMTravel.Tours.API.Application.UseCases.Reservation.V1.Create;
using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Reservation.V1.GetById
{
    public class GetByIdReservationRequest : IRequest<GetByIdReservationResult>
    {
        public int Id { get; set; }

        public GetByIdReservationRequest(int id)
        {
            Id = id;
        }
    }
}
