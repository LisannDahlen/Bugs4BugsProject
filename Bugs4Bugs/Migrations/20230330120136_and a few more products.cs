using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class andafewmoreproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 8,
                column: "PhotoURL",
                value: "Images/BookBeat.png");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PhotoURL" },
                values: new object[,]
                {
                    { 9, null, "Blocket", "Images/Blocket.png" },
                    { 10, null, "Ebay", "Images/Ebay.png" },
                    { 11, null, "Microsoft Teams", "Images/Teams.png" },
                    { 12, null, "Youtube", "Images/Youtube.png" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87d7abe5-d964-4f94-95e1-de9f55b176a8", "1473fd15-60dc-4445-bd97-f004b4c4efe9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhotoURL",
                value: "Images/Netflix.png");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 6, 13, 52, 15, 900, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 4, 2, 13, 52, 15, 900, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 3, 30, 13, 52, 15, 900, DateTimeKind.Local).AddTicks(7987), new DateTime(2023, 3, 30, 13, 52, 15, 900, DateTimeKind.Local).AddTicks(7986) });
        }
    }
}
