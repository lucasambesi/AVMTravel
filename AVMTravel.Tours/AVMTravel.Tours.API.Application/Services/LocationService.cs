using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

namespace AVMTravel.Tours.API.Application.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationQuery _locationQuery;

        public LocationService(ILocationQuery locationQuery)
        {
            _locationQuery = locationQuery;
        }

        public async Task<List<LocationDto>> GetAllAsync()
        {
            return await _locationQuery.GetAllAsync();
        }

        public async Task<LocationDto?> GetByIdAsync(int id)
        {
            return await _locationQuery.GetByIdAsync(id);
        }
    }
}
