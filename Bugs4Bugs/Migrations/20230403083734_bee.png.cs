using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class beepng : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67a5c16d-18a1-4d09-b779-8c03677bcc19", "e04bae74-5a54-4675-a4a8-e6a634d8b9f0" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "PhotoURL",
                value: "Images/bee.png");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 10, 10, 37, 34, 678, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 4, 6, 10, 37, 34, 678, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 3, 10, 37, 34, 678, DateTimeKind.Local).AddTicks(4442), new DateTime(2023, 4, 3, 10, 37, 34, 678, DateTimeKind.Local).AddTicks(4440) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "31449e13-da04-4450-9e43-432db15b3f0c", "fc2ad81f-edb7-4297-bedd-215a11273eae" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "PhotoURL",
                value: "Images/Logov1 (1).png");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 10, 10, 12, 3, 890, DateTimeKind.Local).AddTicks(9456), new DateTime(2023, 4, 6, 10, 12, 3, 890, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 3, 10, 12, 3, 890, DateTimeKind.Local).AddTicks(9461), new DateTime(2023, 4, 3, 10, 12, 3, 890, DateTimeKind.Local).AddTicks(9460) });
        }
    }
}
