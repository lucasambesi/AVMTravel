using AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AVMTravel.Tours.API.Controllers.Location.V1
{
    public partial class LocationController
    {
        /// <summary>
        /// Create Location
        /// </summary>
        /// <remarks>
        /// Location module
        /// </remarks>
        /// <param name="location">
        /// location object
        /// </param>
        /// <returns></returns>
        /// <response code="200">Created</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [ProducesResponseType(typeof(CreateLocationResult), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> CreateLocationAsync(
            [FromBody] CreateLocationRequest location,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var result = await _mediator.Send(location);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { ErrorMessage = ex.Message });
            }
        }
    }
}
