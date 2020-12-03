using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eMenka.Data.Migrations
{
    public partial class completedseedingrecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CostAllocationId", "EndDate", "StartDate" },
                values: new object[] { 1, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2017, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 7,
                column: "CorporationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CorporationId", "StartDate" },
                values: new object[] { 2, new DateTime(2012, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 9,
                column: "CorporationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 10,
                column: "CorporationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 11,
                column: "CorporationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 12,
                column: "CorporationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 13,
                column: "CorporationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 15,
                column: "CorporationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 16,
                column: "CorporationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 17,
                column: "CorporationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 18,
                column: "CorporationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 19,
                column: "CorporationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 20,
                column: "CorporationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 21,
                column: "CorporationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 22,
                column: "CorporationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 24,
                column: "CorporationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 25,
                column: "CorporationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 26,
                column: "CorporationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 27,
                column: "CorporationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CorporationId", "EndDate", "StartDate" },
                values: new object[] { 3, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CostAllocationId", "EndDate", "StartDate" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 7,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CorporationId", "StartDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 9,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 10,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 11,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 12,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 13,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 15,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 16,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 17,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 18,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 19,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 20,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 21,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 22,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 24,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 25,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 26,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 27,
                column: "CorporationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CorporationId", "EndDate", "StartDate" },
                values: new object[] { null, null, null });
        }
    }
}
