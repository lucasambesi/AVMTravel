using AVMTravel.Tours.API.Application.UseCases.Tours.V1.GetById;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AVMTravel.Tours.API.Controllers.Tour.V1
{
    public partial class TourController
    {
        /// <summary>
        /// Get Tour by Id
        /// </summary>
        /// <remarks>
        /// Tour
        /// </remarks>
        /// <param name="id"> Id </param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns></returns>
        /// <response code="200">Ok</response>
        /// <response code="400">Invalid request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetByIdTourRequest), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetTourByIdAsync(
            [FromRoute] int id,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var request = new GetByIdTourRequest(id);

                var result = await _mediator.Send(request, cancellationToken);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { ErrorMessage = ex.Message });
            }
        }
    }
}
