using AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AVMTravel.Tours.API.Controllers.Location.V1
{
    public partial class LocationController
    {/// <summary>
     /// Get Group by Id
     /// </summary>
     /// <remarks>
     /// PBI 104: [reu-ms-groups] - Groups
     /// </remarks>
     /// <param name="id"> Id </param>
     /// <param name="withMembers"> WithMembers </param>
     /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
     /// <returns></returns>
     /// <response code="200">Ok</response>
     /// <response code="400">Invalid request</response>
     /// <response code="401">Unauthorized</response>
     /// <response code="404">Not Found</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetByIdLocationRequest), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetLocationByIdAsync(
            [FromRoute] int id,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetByIdLocationRequest(id);

            var result = await _mediator.Send(request, cancellationToken);

            return new OkObjectResult(result);
        }
    }
}


