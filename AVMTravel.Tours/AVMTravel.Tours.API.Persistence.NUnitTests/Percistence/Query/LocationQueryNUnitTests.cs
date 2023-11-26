using AVMTravel.Tours.API.Persistence.Common;
using NUnit.Framework;

namespace AVMTravel.Tours.API.Persistence.Percistence.Query
{
    [TestFixture, Category("UnitTests")]
    public class LocationQueryNUnitTests
    {
        private ContextDbMock _contextDbMock = new();
        private LocationQuery _locationQuery;

        [SetUp]
        public void SetUp()
        {
            var mapConfig = new MapperMock();
            var mapper = mapConfig.GetMapper();

            _locationQuery = new LocationQuery(_contextDbMock.GetDbContext(), mapper);
        }

        [Test(Description = "Should_be_valid_getById")]
        public async Task Should_be_valid_getById()
        {
            // Arrange
            int locationId = 1;

            // Act
            var result = await _locationQuery.GetByIdAsync(locationId);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual("Salta", result.Name);
        }

        [Test(Description = "Should_be_valid_null_getById")]
        public async Task Should_be_valid_null_getById()
        {
            // Arrange
            int locationId = 9999;

            // Act
            var result = await _locationQuery.GetByIdAsync(locationId);

            // Assert
            Assert.IsNull(result);
        }

        [Test(Description = "Should_be_no_valid_getById")]
        public async Task Should_be_no_valid_getById()
        {
            // Arrange
            int locationId = 1;

            // Act
            var result = await _locationQuery.GetByIdAsync(locationId);

            // Assert
            Assert.NotNull(result);
            Assert.AreNotEqual("Mendoza", result.Name);
        }
    }
}
