using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.GetById
{
    public class GetByIdTourRequest : IRequest<GetByIdTourResult>
    {
        public int Id { get; set; }

        public GetByIdTourRequest(int id)
        {
            Id = id;
        }
    }
}
