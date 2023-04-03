using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class addedbugs4bugsproducttoproductlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "31449e13-da04-4450-9e43-432db15b3f0c", "fc2ad81f-edb7-4297-bedd-215a11273eae" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PhotoURL" },
                values: new object[] { 13, null, "Bugs4Bugs", "Images/Logov1 (1).png" });

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

            migrationBuilder.UpdateData(
                table: "Urgencies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ColorHexString",
                value: "#FFCD29");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42352816-d31d-4541-b0b9-7164af3bf334", "6d267d1d-1d37-4c89-aac1-6443ba2dcb54" });

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
                keyValue: 2,
                column: "ColorHexString",
                value: "FFCD29");
        }
    }
}
