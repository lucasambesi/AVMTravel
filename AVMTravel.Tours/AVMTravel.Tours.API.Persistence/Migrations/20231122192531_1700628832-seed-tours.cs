using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AVMTravel.Tours.API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _1700628832seedtours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "AVM",
                table: "Tours",
                columns: new[] { "Id", "CreatedAt", "Description", "DifficultyLevel", "DurationHours", "LocationId", "Name", "Price", "StartDate", "TourGuide", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salta", 2, 2, 1, "Tour de las cumbres", 100m, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan Gutierrez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mendoza", 2, 3, 2, "Aventura en los Andes", 120m, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "María Rodríguez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ciudad Autónoma de Buenos Aires", 1, 4, 3, "Descubriendo Buenos Aires", 150m, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pablo Sánchez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mendoza", 1, 5, 2, "Ruta del Vino en Mendoza", 180m, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura García", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santa Cruz", 3, 6, 4, "Senderismo en Patagonia", 200m, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luis Fernández", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santa Cruz", 2, 4, 4, "Aventuras en el Glaciar Perito Moreno", 180m, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana Martínez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salta", 1, 3, 1, "Historia y Cultura en Salta", 150m, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos López", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Misiones", 2, 5, 5, "Aventura en las Cataratas del Iguazú", 200m, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patricia Pérez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tierra del Fuego", 2, 4, 6, "Explorando Ushuaia", 170m, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrés Gómez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ciudad Autónoma de Buenos Aires", 1, 3, 3, "Aventuras Gastronómicas en Buenos Aires", 160m, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carolina Díaz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salta", 1, 4, 1, "Recorrido por Cafayate y sus Bodegas", 180m, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sergio Torres", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Río Negro", 2, 5, 7, "Aventuras Acuáticas en Bariloche", 190m, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriela Ruiz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santa Cruz", 3, 7, 4, "Descubriendo la Ruta 40", 220m, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Javier Ramírez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Luis", 2, 4, 8, "Aventuras en la Sierra de las Quijadas", 170m, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paula Herrera", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santa Cruz", 3, 6, 4, "Ruta de los Glaciares en Santa Cruz", 200m, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martín Castro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
