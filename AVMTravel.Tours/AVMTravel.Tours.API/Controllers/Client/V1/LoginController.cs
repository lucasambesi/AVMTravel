using AVMTravel.Tours.API.Application.UseCases.Client.V1.Login;
using AVMTravel.Tours.API.Application.UseCases.Client.V1.Register;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AVMTravel.Tours.API.Controllers.Client.V1
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// LoginHandler Client
        /// </summary>
        /// <remarks>
        /// Client
        /// </remarks>
        /// <param name="client">client</param>
        /// <returns></returns>
        /// <response code="200">Created</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [ProducesResponseType(typeof(LoginResult), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> LoginClientAsync(
            [FromBody] LoginRequest client,
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
