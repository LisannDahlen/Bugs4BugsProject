using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class statusandurgencycolorsupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42352816-d31d-4541-b0b9-7164af3bf334", "6d267d1d-1d37-4c89-aac1-6443ba2dcb54" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "ColorHexString",
                value: "#adb5bd");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 6, 23, 2, 4, 908, DateTimeKind.Local).AddTicks(7586), new DateTime(2023, 4, 2, 23, 2, 4, 908, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 23, 2, 4, 908, DateTimeKind.Local).AddTicks(7603), new DateTime(2023, 3, 30, 23, 2, 4, 908, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Urgencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ColorHexString",
                value: "#0D6EFD");

            migrationBuilder.UpdateData(
                table: "Urgencies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ColorHexString",
                value: "#FD7E14");

            migrationBuilder.UpdateData(
                table: "Urgencies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ColorHexString",
                value: "#DC3545");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Urgencies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ColorHexString",
                value: "80E615");

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
    }
}
