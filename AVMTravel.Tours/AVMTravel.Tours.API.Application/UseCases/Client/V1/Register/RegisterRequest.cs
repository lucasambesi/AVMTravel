using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Client.V1.Register
{
    public class RegisterRequest : IRequest<RegisterResult>
    {
        public string FullName { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }
    }
}
