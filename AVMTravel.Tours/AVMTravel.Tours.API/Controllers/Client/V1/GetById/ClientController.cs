using AVMTravel.Tours.API.Application.UseCases.Client.V1.GetById;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AVMTravel.Tours.API.Controllers.Client.V1
{
    public partial class ClientController
    {
        /// <summary>
        /// Get Client by Id
        /// </summary>
        /// <remarks>
        /// Client module
        /// </remarks>
        /// <param name="id">
        /// Client Id
        /// </param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns></returns>
        /// <response code="200">Ok</response>
        /// <response code="400">Invalid request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Business error</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetByIdClientRequest), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetClientByIdAsync(
            [FromRoute] int id,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var request = new GetByIdClientRequest(id);

                var result = await _mediator.Send(request, cancellationToken);

                return Ok(result);
            }
            catch (ApiException ex)
            {
                return StatusCode((int)ex.Code, new { ErrorMessage = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { ErrorMessage = ex.Message });
            }
        }
    }
}
