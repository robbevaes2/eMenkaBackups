using Microsoft.EntityFrameworkCore.Migrations;

namespace eMenka.Data.Migrations
{
    public partial class resetEnumsToClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoorType",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "FuelTypeId",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LicensePlate",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DoorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DoorTypeId",
                table: "Vehicles",
                column: "DoorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FuelTypeId",
                table: "Vehicles",
                column: "FuelTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_DoorTypes_DoorTypeId",
                table: "Vehicles",
                column: "DoorTypeId",
                principalTable: "DoorTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_FuelTypes_FuelTypeId",
                table: "Vehicles",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_DoorTypes_DoorTypeId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_FuelTypes_FuelTypeId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "DoorTypes");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_DoorTypeId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_FuelTypeId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "FuelTypeId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "LicensePlate",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "DoorType",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FuelType",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
