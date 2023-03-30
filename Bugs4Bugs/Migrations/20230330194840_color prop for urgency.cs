using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class colorpropforurgency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ColorHexString",
                table: "Urgencies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Urgencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ColorHexString",
                value: "80E615");

            migrationBuilder.UpdateData(
                table: "Urgencies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ColorHexString",
                value: "FFCD29");

            migrationBuilder.UpdateData(
                table: "Urgencies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ColorHexString",
                value: "FF6715");

            migrationBuilder.UpdateData(
                table: "Urgencies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ColorHexString",
                value: "FF0000");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorHexString",
                table: "Urgencies");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dba4e99a-ec28-4f6d-9f18-40e12e3ea6d5", "53f013e3-9d57-49f6-b9b1-3bb64a0e2542" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 13, 40, 278, DateTimeKind.Local).AddTicks(338), new DateTime(2023, 4, 2, 14, 13, 40, 278, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 14, 13, 40, 278, DateTimeKind.Local).AddTicks(354), new DateTime(2023, 3, 30, 14, 13, 40, 278, DateTimeKind.Local).AddTicks(352) });
        }
    }
}
