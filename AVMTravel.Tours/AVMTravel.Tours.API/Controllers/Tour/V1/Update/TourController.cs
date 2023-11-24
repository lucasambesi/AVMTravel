using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Update;
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
        /// <response code="404">Not Found</response>
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
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { ErrorMessage = ex.Message });
            }
        }
    }
}
