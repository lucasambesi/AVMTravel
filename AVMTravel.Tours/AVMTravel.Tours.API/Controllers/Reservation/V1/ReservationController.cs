using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AVMTravel.Tours.API.Controllers.Reservation.V1
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/reservations")]
    //[Authorize(AuthenticationSchemes = "AuthToken")]
    public partial class ReservationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
