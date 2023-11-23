using MediatR;

namespace AVMTravel.Tours.API.Application.UseCases.Client.V1.Login
{
    public class LoginRequest : IRequest<LoginResult>
    {
        public string? Password { get; set; }

        public string? Email { get; set; }
    }
}
