using AutoMapper;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using AVMTravel.Tours.API.Domain.Interfaces.Services;

namespace AVMTravel.Tours.API.Application.Services
{
    public class TourService : ITourService
    {
        private readonly ITourQuery _tourQuery;
        private readonly ITourRepository _tourRepository;
        private readonly IMapper _mapper;

        public TourService(
            ITourQuery tourQuery,
            ITourRepository tourRepository,
            IMapper mapper)
        {
            _tourQuery = tourQuery;
            _tourRepository = tourRepository;
            _mapper = mapper;
        }

        public async Task<bool> InsertAsync(TourDto tourDto)
        {
            var tour = _mapper.Map<Tour>(tourDto);

            return await _tourRepository.InsertAsync(tour);
        }

        public async Task<TourDto?> GetByIdAsync(int id)
        {
            return await _tourQuery.GetByIdAsync(id);
        }
    }
}
