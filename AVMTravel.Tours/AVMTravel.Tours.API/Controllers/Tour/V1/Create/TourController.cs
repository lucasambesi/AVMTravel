using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Create;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AVMTravel.Tours.API.Controllers.Tour.V1
{
    public partial class TourController
    {
        /// <summary>
        /// Create Tour
        /// </summary>
        /// <remarks>
        /// Tour
        /// </remarks>
        /// <param name="tour">tour</param>
        /// <returns></returns>
        /// <response code="200">Deleted</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [ProducesResponseType(typeof(CreateTourResult), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> CreateTourAsync(
            [FromBody] CreateTourRequest tour,
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
