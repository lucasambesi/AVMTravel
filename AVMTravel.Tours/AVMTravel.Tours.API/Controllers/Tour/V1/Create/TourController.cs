﻿using AVMTravel.Tours.API.Application.UseCases.Tours.V1.Create;
using AVMTravel.Tours.API.Domain.Helpers.Exceptions;
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
        /// Tour module
        /// </remarks>
        /// <param name="tour">tour object</param>
        /// <returns></returns>
        /// <response code="200">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        /// <response code="422">Business error</response>
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
