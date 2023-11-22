using AVMTravel.Tours.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace AVMTravel.Tours.API.Persistence.Configurations.Seeds
{
    [ExcludeFromCodeCoverage]
    public class LocationSeed : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                    new Location { Id = 1, Name = "Salta" },
                    new Location { Id = 2, Name = "Mendoza" },
                    new Location { Id = 3, Name = "Ciudad Autónoma de Buenos Aires" },
                    new Location { Id = 4, Name = "Santa Cruz" },
                    new Location { Id = 5, Name = "Misiones" },
                    new Location { Id = 6, Name = "Tierra del Fuego" },
                    new Location { Id = 7, Name = "Río Negro" },
                    new Location { Id = 8, Name = "San Luis" }
            );
        }
}
}
