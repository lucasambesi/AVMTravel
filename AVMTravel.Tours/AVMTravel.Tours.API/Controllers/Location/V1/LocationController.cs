using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AVMTravel.Tours.API.Controllers.Location.V1
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/locations")]
    public partial class LocationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
