using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Persistence.Common;
using NUnit.Framework;


namespace AVMTravel.Tours.API.Persistence.Percistence.Command
{
    [TestFixture, Category("UnitTests")]
    public class LocationRepositoryNUnitTests
    {
        private ContextDbMock _contextDbMock = new();
        private LocationRepository _locationRepository;

        [SetUp]
        public void SetUp()
        {
            var mapConfig = new MapperMock();
            var mapper = mapConfig.GetMapper();

            _locationRepository = new LocationRepository(_contextDbMock.GetDbContext(), mapper);            
        }

        [Test(Description = "Should_be_valid_insert")]
        public async Task Should_be_valid_insert()
        {
            // Arrange
            var location = new Location()
            {
                Name = "Santa cruz"
            };

            // Act
            var result = await _locationRepository.InsertAsync(location);

            // Assert
            Assert.IsTrue(result > 0);
        }
    }
}
