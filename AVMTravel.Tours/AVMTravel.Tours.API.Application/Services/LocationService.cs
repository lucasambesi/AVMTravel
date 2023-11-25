using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

namespace AVMTravel.Tours.API.Application.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationQuery _locationQuery;
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public LocationService(
            ILocationQuery locationQuery, 
            ILocationRepository locationRepository, 
            IMapper mapper)
        {
            _locationQuery = locationQuery;
            _locationRepository = locationRepository;
            _mapper = mapper;
        }

        public async Task<int> InsertAsync(LocationDto locationDto)
        {
            var location = _mapper.Map<Location>(locationDto);

            return await _locationRepository.InsertAsync(location);
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
