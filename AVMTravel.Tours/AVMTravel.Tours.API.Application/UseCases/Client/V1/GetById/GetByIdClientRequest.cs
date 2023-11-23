using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Client.V1.GetById
{
    public class GetByIdClientRequest : IRequest<GetByIdClientResult>
    {
        public int Id { get; set; }

        public GetByIdClientRequest(int id)
        {
            Id = id;
        }
    }
}
