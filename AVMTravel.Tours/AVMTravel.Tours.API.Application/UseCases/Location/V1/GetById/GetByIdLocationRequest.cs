using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById
{
    public class GetByIdLocationRequest : IRequest<GetByIdLocationResult>
    {
        public int Id { get; set; }

        public GetByIdLocationRequest(int id)
        {
            Id = id;
        }
    }
}
