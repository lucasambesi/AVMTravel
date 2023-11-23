using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AVMTravel.Tours.API.Controllers.Tour.V1
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/tours")]
    public partial class TourController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TourController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
