using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Tours.V1.Delete
{
    public class DeleteTourRequest : IRequest<DeleteTourResult>
    {
        public int Id { get; set; }

        public DeleteTourRequest(int id)
        {
            Id = id;
        }
    }
}
