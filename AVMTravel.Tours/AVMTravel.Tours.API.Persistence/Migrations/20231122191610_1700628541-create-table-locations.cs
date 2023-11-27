using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVMTravel.Tours.API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _1700628541createtablelocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                schema: "AVM",
                table: "Tours");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                schema: "AVM",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Locations",
                schema: "AVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_LocationId",
                schema: "AVM",
                table: "Tours",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Locations_LocationId",
                schema: "AVM",
                table: "Tours",
                column: "LocationId",
                principalSchema: "AVM",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Locations_LocationId",
                schema: "AVM",
                table: "Tours");

            migrationBuilder.DropTable(
                name: "Locations",
                schema: "AVM");

            migrationBuilder.DropIndex(
                name: "IX_Tours_LocationId",
                schema: "AVM",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "LocationId",
                schema: "AVM",
                table: "Tours");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                schema: "AVM",
                table: "Tours",
                type: "varchar(250)",
                unicode: false,
                maxLength: 250,
                nullable: true);
        }
    }
}
