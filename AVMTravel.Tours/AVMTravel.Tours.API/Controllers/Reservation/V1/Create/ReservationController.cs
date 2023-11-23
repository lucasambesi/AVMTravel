using AVMTravel.Tours.API.Application.UseCases.Reservation.V1.Create;
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
        /// Reservation
        /// </remarks>
        /// <param name="reservation">reservation</param>
        /// <returns></returns>
        /// <response code="200">Deleted</response>
        /// <response code="404">Not Found</response>
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
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new { ErrorMessage = ex.Message });
            }
        }
    }
}
