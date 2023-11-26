using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Update;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AVMTravel.Tours.API.Controllers.Tour.V1
{
    public partial class TourController
    {
        /// <summary>
        /// Update Tour
        /// </summary>
        /// <remarks>
        /// Tour module
        /// </remarks>
        /// <param name="tour">
        /// tour object
        /// </param>
        /// <returns></returns>
        /// <response code="200">Updated</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Business error</response>
        [HttpPut]
        [ProducesResponseType(typeof(UpdateTourResult), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateTourAsync(
            [FromBody] UpdateTourRequest tour,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var result = await _mediator.Send(tour);

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
