using Microsoft.EntityFrameworkCore.Migrations;

namespace eMenka.Data.Migrations
{
    public partial class missedonecorporationidinlastmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 3,
                column: "CorporationId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 3,
                column: "CorporationId",
                value: null);
        }
    }
}
