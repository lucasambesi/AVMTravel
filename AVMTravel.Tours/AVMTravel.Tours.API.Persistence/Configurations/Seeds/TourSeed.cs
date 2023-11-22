using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace AVMTravel.Tours.API.Persistence.Configurations.Seeds
{
    public class TourSeed : IEntityTypeConfiguration<Tour>
    {
        [ExcludeFromCodeCoverage]
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.HasData(
                new Tour { Id = 1, Name = "Tour de las cumbres", Description = "Salta", StartDate = new DateTime(2024, 4, 1), DurationHours = 2, Price = 100, LocationId = 1, TourGuide = "Juan Gutierrez", DifficultyLevel = EDifficultyLevelType.Medium },
                new Tour { Id = 2, Name = "Aventura en los Andes", Description = "Mendoza", StartDate = new DateTime(2024, 4, 2), DurationHours = 3, Price = 120, LocationId = 2, TourGuide = "María Rodríguez", DifficultyLevel = EDifficultyLevelType.Medium },
                new Tour { Id = 3, Name = "Descubriendo Buenos Aires", Description = "Ciudad Autónoma de Buenos Aires", StartDate = new DateTime(2024, 4, 5), DurationHours = 4, Price = 150, LocationId = 3, TourGuide = "Pablo Sánchez", DifficultyLevel = EDifficultyLevelType.Easy },
                new Tour { Id = 4, Name = "Ruta del Vino en Mendoza", Description = "Mendoza", StartDate = new DateTime(2024, 4, 8), DurationHours = 5, Price = 180, LocationId = 2, TourGuide = "Laura García", DifficultyLevel = EDifficultyLevelType.Easy },
                new Tour { Id = 5, Name = "Senderismo en Patagonia", Description = "Santa Cruz", StartDate = new DateTime(2024, 4, 11), DurationHours = 6, Price = 200, LocationId = 4, TourGuide = "Luis Fernández", DifficultyLevel = EDifficultyLevelType.Hard },
                new Tour { Id = 6, Name = "Aventuras en el Glaciar Perito Moreno", Description = "Santa Cruz", StartDate = new DateTime(2024, 4, 14), DurationHours = 4, Price = 180, LocationId = 4, TourGuide = "Ana Martínez", DifficultyLevel = EDifficultyLevelType.Medium },
                new Tour { Id = 7, Name = "Historia y Cultura en Salta", Description = "Salta", StartDate = new DateTime(2024, 4, 17), DurationHours = 3, Price = 150, LocationId = 1, TourGuide = "Carlos López", DifficultyLevel = EDifficultyLevelType.Easy },
                new Tour { Id = 8, Name = "Aventura en las Cataratas del Iguazú", Description = "Misiones", StartDate = new DateTime(2024, 4, 20), DurationHours = 5, Price = 200, LocationId = 5, TourGuide = "Patricia Pérez", DifficultyLevel = EDifficultyLevelType.Medium },
                new Tour { Id = 9, Name = "Explorando Ushuaia", Description = "Tierra del Fuego", StartDate = new DateTime(2024, 4, 23), DurationHours = 4, Price = 170, LocationId = 6, TourGuide = "Andrés Gómez", DifficultyLevel = EDifficultyLevelType.Medium },
                new Tour { Id = 10, Name = "Aventuras Gastronómicas en Buenos Aires", Description = "Ciudad Autónoma de Buenos Aires", StartDate = new DateTime(2024, 4, 26), DurationHours = 3, Price = 160, LocationId = 3, TourGuide = "Carolina Díaz", DifficultyLevel = EDifficultyLevelType.Easy },
                new Tour { Id = 11, Name = "Recorrido por Cafayate y sus Bodegas", Description = "Salta", StartDate = new DateTime(2024, 4, 29), DurationHours = 4, Price = 180, LocationId = 1, TourGuide = "Sergio Torres", DifficultyLevel = EDifficultyLevelType.Easy },
                new Tour { Id = 12, Name = "Aventuras Acuáticas en Bariloche", Description = "Río Negro", StartDate = new DateTime(2024, 5, 2), DurationHours = 5, Price = 190, LocationId = 7, TourGuide = "Gabriela Ruiz", DifficultyLevel = EDifficultyLevelType.Medium },
                new Tour { Id = 13, Name = "Descubriendo la Ruta 40", Description = "Santa Cruz", StartDate = new DateTime(2024, 5, 5), DurationHours = 7, Price = 220, LocationId = 4, TourGuide = "Javier Ramírez", DifficultyLevel = EDifficultyLevelType.Hard },
                new Tour { Id = 14, Name = "Aventuras en la Sierra de las Quijadas", Description = "San Luis", StartDate = new DateTime(2024, 5, 8), DurationHours = 4, Price = 170, LocationId = 8, TourGuide = "Paula Herrera", DifficultyLevel = EDifficultyLevelType.Medium },
                new Tour { Id = 15, Name = "Ruta de los Glaciares en Santa Cruz", Description = "Santa Cruz", StartDate = new DateTime(2024, 5, 11), DurationHours = 6, Price = 200, LocationId = 4, TourGuide = "Martín Castro", DifficultyLevel = EDifficultyLevelType.Hard }
            );
        }
    }
}
