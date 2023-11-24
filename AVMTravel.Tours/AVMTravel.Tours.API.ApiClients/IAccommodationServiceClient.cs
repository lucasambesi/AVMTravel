using AVMTravel.Tours.API.ApiClients.Dtos.Accommodation;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMTravel.Tours.API.ApiClients
{
    public interface IAccommodationServiceClient
    {
        [Get("/api/hotels/location/{locationId}")]
        Task<IEnumerable<HotelDto>> GetHotelByLocationIdAsync(int locationId);
    }
}
