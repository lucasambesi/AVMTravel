using AVMTravel.Tours.API.Application.UseCases.Reservation.V1.Create;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AVMTravel.Tours.API.Controllers.Reservation.V1
{
    public partial class ReservationController
    {
        /// <summary>
        /// Create Reservation
        /// </summary>
        /// <remarks>
        /// clientId and tourId
        /// </remarks>
        /// <param name="reservation">reservation object</param>
        /// <returns></returns>
        /// <response code="200">Created</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Business error</response>
        [HttpPost]
        [ProducesResponseType(typeof(CreateReservationResult), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> CreateReservationAsync(
            [FromBody] CreateReservationRequest reservation,
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
