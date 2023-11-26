using AVMTravel.Tours.API.Application.UseCases.Client.V1.Register;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AVMTravel.Tours.API.Controllers.Client.V1
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/register")]
    public partial class RegisterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RegisterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Register Client
        /// </summary>
        /// <remarks>
        /// Client module
        /// </remarks>
        /// <param name="client">
        /// email, password and full name
        /// </param>
        /// <returns></returns>
        /// <response code="200">Register</response>
        /// <response code="404">Not Found</response>
        /// /// <response code="422">Business error</response>
        [HttpPost]
        [ProducesResponseType(typeof(RegisterResult), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> RegisterClientAsync(
            [FromBody] RegisterRequest client,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var result = await _mediator.Send(client);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { ErrorMessage = ex.Message });
            }
        }
    }
}
