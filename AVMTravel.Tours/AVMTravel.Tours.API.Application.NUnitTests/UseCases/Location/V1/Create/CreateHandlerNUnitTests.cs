using AutoMapper;
using AVMTravel.Tours.API.Application.Mappings;
using AVMTravel.Tours.API.Application.UseCases.Locations.V1.Create;
using AVMTravel.Tours.API.Domain.DTOs;
using AVMTravel.Tours.API.Domain.Interfaces.Services;
using Moq;
using NUnit.Framework;

namespace AVMTravel.Tours.API.Application.UseCases.Location.V1.Create
{
    [TestFixture, Category("UnitTests")]
    public class CreateHandlerNUnitTests
    {
        private CreateHandler _handler;

        private readonly Mock<ILocationService> _locationServiceMock = new Mock<ILocationService>();

        [SetUp]
        public void SetUp()
        {
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingLocationTest());
            });
            var mapper = mapConfig.CreateMapper();

            _handler = new CreateHandler(_locationServiceMock.Object,
                                        mapper
                                        );
        }

        [Test(Description = "Should_be_valid_CreateHandler")]
        public async Task Should_be_valid_CreateHandler()
        {
            // Arrange
            LocationDto location = new() { Name = "Chubut" };
            CreateLocationRequest request = new CreateLocationRequest() { Name="Chubut" };

            _locationServiceMock.Setup(mock => mock.InsertAsync(It.IsAny<LocationDto>()))
                .ReturnsAsync(1)
                .Verifiable();

            // Act
            var result = await _handler.Handle(request, new CancellationToken());

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(true, result.Created);

            _locationServiceMock.Verify(mock => mock.InsertAsync(It.IsAny<LocationDto>()), Times.Once);

        }
    }
}
