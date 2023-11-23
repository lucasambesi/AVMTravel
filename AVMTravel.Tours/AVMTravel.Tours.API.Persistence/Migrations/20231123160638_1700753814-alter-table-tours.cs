using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVMTravel.Tours.API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _1700753814altertabletours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                schema: "AVM",
                table: "Tours",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 11,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 12,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 13,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 14,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                schema: "AVM",
                table: "Tours",
                keyColumn: "Id",
                keyValue: 15,
                column: "Active",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                schema: "AVM",
                table: "Tours");
        }
    }
}
