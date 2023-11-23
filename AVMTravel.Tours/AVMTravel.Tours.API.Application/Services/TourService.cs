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

        public async Task<bool> DeleteAsync(int id)
        {
            var tourDto = await GetByIdAsync(id);

            if(tourDto == null)
            {
                return true;
            }

            tourDto.Active = false;

            var tour = _mapper.Map<Tour>(tourDto);

            return await _tourRepository.UpdateAsync(tour);
        }

        public async Task<bool> UpdateAsync(TourDto existingTour, TourDto newTour)
        {           
            existingTour.Name = newTour.Name;
            existingTour.Description = newTour.Description;
            existingTour.StartDate = newTour.StartDate;
            existingTour.DurationHours = newTour.DurationHours;
            existingTour.Price = newTour.Price;
            existingTour.LocationId = newTour.LocationId;
            existingTour.TourGuide = newTour.TourGuide;
            existingTour.DifficultyLevel = newTour.DifficultyLevel;

            var tour = _mapper.Map<Tour>(existingTour);

            return await _tourRepository.UpdateAsync(tour);
        }

        public async Task<TourDto?> GetByIdAsync(int id)
        {
            return await _tourQuery.GetByIdAsync(id);
        }
    }
}
