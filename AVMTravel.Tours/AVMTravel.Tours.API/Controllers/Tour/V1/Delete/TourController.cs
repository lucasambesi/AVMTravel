using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Delete;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AVMTravel.Tours.API.Controllers.Tour.V1
{
    public partial class TourController
    {
        /// <summary>
        /// Delete Tour
        /// </summary>
        /// <remarks>
        /// Tour module
        /// </remarks>
        /// <param name="id"> Tour Id </param>
        /// <returns></returns>
        /// <response code="200">Deleted</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(DeleteTourResult), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteTourAsync(
            [FromRoute] int id,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var request = new DeleteTourRequest(id);

                var result = await _mediator.Send(request);

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
