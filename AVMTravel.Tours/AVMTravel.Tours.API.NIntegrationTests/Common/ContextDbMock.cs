using AutoFixture;
using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AVMTravel.Tours.API.NIntegrationTests.Common
{
    public class ContextDbMock
    {
        private BaseContext _baseContext;

        public ContextDbMock()
        {
            var options = new DbContextOptionsBuilder<BaseContext>()
                .UseInMemoryDatabase(databaseName: $"AVMTrave.Tours-{new Guid()}")
                .Options;

            _baseContext = new BaseContext(options);

            AddLocationRecords();
        }

        private void AddLocationRecords()
        {
            var fixture = new Fixture();

            var records = fixture.CreateMany<Location>().ToList();

            var locationsToInsert = new List<Location>
            {
                fixture.Build<Location>()
                    .With(tr => tr.Id, 1)
                    .With(tr => tr.Name, "Salta")
                    .Create(),
                fixture.Build<Location>()
                    .With(tr => tr.Id, 2)
                    .With(tr => tr.Name, "Mendoza")
                    .Create(),
            };

            foreach (var location in locationsToInsert)
            {
                var existingLocation = _baseContext.Locations.Find(location.Id);

                if (existingLocation == null)
                {
                    _baseContext.Locations.Add(location);
                }
            }

            _baseContext.SaveChanges();
        }

        public BaseContext GetDbContext() => _baseContext;
    }
}
