using AutoMapper;
using AVMTravel.Tours.API.Application.Mappings;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Interfaces.Commands;
using AVMTravel.Tours.API.Domain.Interfaces.Queries;
using Moq;
using NUnit.Framework;

namespace AVMTravel.Tours.API.Application.Services
{
    [TestFixture, Category("UnitTests")]
    public class LocationServiceNUnitTests
    {
        private LocationService _locationService;

        private readonly Mock<ILocationQuery> _locationQueryMock = new Mock<ILocationQuery>();
        private readonly Mock<ILocationRepository> _locationRepositoryMock = new Mock<ILocationRepository>();

        [SetUp]
        public void SetUp()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingLocationTest());
            });

            var mapper = mapConfig.CreateMapper();

            _locationService = new LocationService(_locationQueryMock.Object, 
                                                   _locationRepositoryMock.Object, 
                                                   mapper);
        }

        [Test(Description = "Should_be_valid_getById")]
        public async Task Should_be_valid_getById()
        {
            // Arrange
            int locationId = 1;

            _locationQueryMock.Setup(mock => mock.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(new LocationDto()
                {
                    Id = locationId, Name = "Salta"
                })
                .Verifiable();

            // Act
            var result = await _locationService.GetByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual("Salta", result.Name);

            _locationQueryMock.Verify(mock => mock.GetByIdAsync(locationId), Times.Once);
        }

        [Test(Description = "Should_be_invalid_getById")]
        public async Task Should_be_invalid_getById()
        {
            // Arrange
            int locationId = 2;

            _locationQueryMock.Setup(mock => mock.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(new LocationDto()
                {
                    Id = locationId,
                    Name = "Salta"
                })
                .Verifiable();

            // Act
            var result = await _locationService.GetByIdAsync(locationId);

            // Assert
            Assert.NotNull(result);
            Assert.AreNotEqual("Mendoza", result.Name);

            _locationQueryMock.Verify(mock => mock.GetByIdAsync(locationId), Times.Once);
        }

        [Test(Description = "Should_return_null_getById_for_nonexistent_ID")]
        public async Task Should_return_null_getById_for_nonexistent_ID()
        {
            // Arrange
            int locationId = 3;

            _locationQueryMock.Setup(mock => mock.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync((LocationDto)null)
                .Verifiable();

            // Act
            var result = await _locationService.GetByIdAsync(locationId);

            // Assert
            Assert.Null(result);
            _locationQueryMock.Verify(mock => mock.GetByIdAsync(locationId), Times.Once);
        }

        [Test(Description = "Should_be_valid_create")]
        public async Task Should_be_valid_create()
        {
            // Arrange
            var locationDto = new LocationDto()
            {
                Id = 1,
                Name = "Salta"
            };

            var location = new Location();

            _locationRepositoryMock.Setup(mock => mock.InsertAsync(It.IsAny<Location>()))
                .ReturnsAsync(locationDto.Id)
                .Verifiable();

            // Act
            var result = await _locationService.InsertAsync(locationDto);

            // Assert
            Assert.NotNull(result);
            Assert.IsTrue(result > 0);

            _locationRepositoryMock.Verify(mock => mock
                .InsertAsync(It.Is<Location>(x => x.Id == locationDto.Id)), Times.Once);
        }

        [Test(Description = "Should_be_invalid_create")]
        public async Task Should_be_invalid_create()
        {
            // Arrange
            var locationDto = new LocationDto()
            {
                Id = 2,
                Name = "Mendoza"
            };

            var location = new Location();

            _locationRepositoryMock.Setup(mock => mock.InsertAsync(It.IsAny<Location>()))
                .ReturnsAsync(0)
                .Verifiable();

            // Act
            var result = await _locationService.InsertAsync(locationDto);

            // Assert
            Assert.NotNull(result);
            Assert.IsFalse(result > 0);

            _locationRepositoryMock.Verify(mock => mock
                .InsertAsync(It.Is<Location>(x => x.Id == locationDto.Id)), Times.Once);
        }
    }
}
