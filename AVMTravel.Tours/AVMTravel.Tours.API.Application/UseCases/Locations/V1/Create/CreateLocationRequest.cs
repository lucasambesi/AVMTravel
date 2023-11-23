using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create
{
    public class CreateLocationRequest : IRequest<CreateLocationResult>
    {
        public string Name { get; set; }
    }
}
