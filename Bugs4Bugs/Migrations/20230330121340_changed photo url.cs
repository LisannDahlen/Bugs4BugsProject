using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class changedphotourl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dba4e99a-ec28-4f6d-9f18-40e12e3ea6d5", "53f013e3-9d57-49f6-b9b1-3bb64a0e2542" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "PhotoURL",
                value: "Images/Teams.jpg");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a76c5cbf-c53c-4ba2-bf57-b28e32bcc620", "441c2d5c-6fbe-41d3-b45f-abaef25bc211" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "PhotoURL",
                value: "Images/Teams.png");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 1, 36, 634, DateTimeKind.Local).AddTicks(4093), new DateTime(2023, 4, 2, 14, 1, 36, 634, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 14, 1, 36, 634, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 3, 30, 14, 1, 36, 634, DateTimeKind.Local).AddTicks(4098) });
        }
    }
}
