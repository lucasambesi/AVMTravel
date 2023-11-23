using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AVMTravel.Tours.API.Controllers.Client.V1
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/clients")]
    [Authorize(AuthenticationSchemes = "AuthToken")]
    public partial class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
