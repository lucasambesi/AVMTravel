using NUnit.Framework;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.GetById;
using Moq;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using AVMTravel.Tours.API.Domain.DTOs;
using AutoMapper;
using AVMTravel.Tours.API.Application.Mappings;
using AVMTravel.Tours.API.ApiClients;
using AVMTravel.Tours.API.ApiClients.Dtos.Accommodation;

namespace AVMTravel.Tours.API.Application.UseCases.Location.V1.GetById
{
    [TestFixture, Category("UnitTests")]
    public class GetByIdHandlerNUnitTests
    {
        private GetByIdHandler _handler;

        private readonly Mock<ILocationService> _locationServiceMock = new Mock<ILocationService>();
        private readonly Mock<IAccommodationServiceClient> _accommodationServiceClientMock = new Mock<IAccommodationServiceClient>();

        [SetUp]
        public void SetUp()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingLocationTest());
            });
            var mapper = mapConfig.CreateMapper();

            _handler = new GetByIdHandler(_locationServiceMock.Object,
                                        mapper,
                                        _accommodationServiceClientMock.Object
                                        );
        }
        
        [Test(Description = "Should_be_valid_GetByIdHandler")]
        public async Task Should_be_valid_GetByIdHandler()
        {
            // Arrange
            int locationId = 1;
            GetByIdLocationRequest request = new(locationId);
            IEnumerable<HotelDto> hotelDtos = new List<HotelDto>();

            _locationServiceMock.Setup(mock => mock.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(new LocationDto()
                {
                    Id = locationId,
                    Name = "Salta"
                })
                .Verifiable();

            _accommodationServiceClientMock.Setup(mock => mock.GetHotelByLocationIdAsync(It.IsAny<int>()))
                .ReturnsAsync(hotelDtos)
                .Verifiable();

            // Act
            var result = await _handler.Handle(request, new CancellationToken());

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual("Salta", result.Name);

            _locationServiceMock.Verify(mock => mock.GetByIdAsync(locationId), Times.Once);

        }
    }
}
