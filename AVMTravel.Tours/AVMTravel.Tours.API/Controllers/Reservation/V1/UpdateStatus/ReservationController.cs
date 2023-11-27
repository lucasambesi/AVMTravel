using AVMTravel.Tours.API.Application.UseCases.Reservation.V1.UpdateStatus;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AVMTravel.Tours.API.Controllers.Reservation.V1
{
    public partial class ReservationController
    {
        /// <summary>
        /// Update Reservation Status
        /// </summary>
        /// <remarks>
        /// Reservation module
        /// </remarks>
        /// <param name="reservation">
        /// reservation object
        /// </param>
        /// <returns></returns>
        /// <response code="200">Updated</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Business error</response>
        [HttpPatch("status")]
        [ProducesResponseType(typeof(UpdateStatusReservationResult), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateReservationStatusAsync(
            [FromBody] UpdateStatusReservationRequest reservation,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var result = await _mediator.Send(reservation);

                return Ok(result);
            }
            catch (ValidationApiException ex)
            {
                return StatusCode((int)ex.Code, new
                {
                    ErrorMessage = ex.Message,
                    Erros = ex.Errors
                });
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
