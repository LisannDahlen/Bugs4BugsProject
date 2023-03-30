using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class colorpropforstatuses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ColorHexString",
                table: "Statuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5994df93-23f6-4334-974e-08ed4941398a", "796a3f3d-2287-4ed8-968e-4c46fc4418b8" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ColorHexString",
                value: "#f8f9fa");

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "ColorHexString",
                value: "#198754");

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "ColorHexString",
                value: "#0d6efd");

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "ColorHexString",
                value: "#FFCD29");

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "ColorHexString",
                value: "#0d6efd");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 6, 22, 47, 19, 241, DateTimeKind.Local).AddTicks(9945), new DateTime(2023, 4, 2, 22, 47, 19, 241, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 22, 47, 19, 241, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 3, 30, 22, 47, 19, 241, DateTimeKind.Local).AddTicks(9959) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorHexString",
                table: "Statuses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4100b5ee-880c-422d-8731-858599713fd8", "a38b8bf7-1b13-4538-9475-f0f4a94a6632" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 6, 21, 48, 40, 166, DateTimeKind.Local).AddTicks(2059), new DateTime(2023, 4, 2, 21, 48, 40, 166, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 21, 48, 40, 166, DateTimeKind.Local).AddTicks(2087), new DateTime(2023, 3, 30, 21, 48, 40, 166, DateTimeKind.Local).AddTicks(2080) });
        }
    }
}
