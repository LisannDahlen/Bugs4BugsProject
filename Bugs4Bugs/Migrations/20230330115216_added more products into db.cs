using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class addedmoreproductsintodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87d7abe5-d964-4f94-95e1-de9f55b176a8", "1473fd15-60dc-4445-bd97-f004b4c4efe9" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PhotoURL" },
                values: new object[,]
                {
                    { 6, null, "Spotify", "Images/Spotify.png" },
                    { 7, null, "Netflix", "Images/Netflix.png" },
                    { 8, null, "BookBeat", "Images/Netflix.png" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a2bb3fb-3af2-4cb2-9b4d-ea32b8135cb1", "0d56a44a-4609-46b4-b98b-23e148c33925" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 5, 16, 45, 14, 63, DateTimeKind.Local).AddTicks(8636), new DateTime(2023, 4, 1, 16, 45, 14, 63, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 3, 29, 16, 45, 14, 63, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 3, 29, 16, 45, 14, 63, DateTimeKind.Local).AddTicks(8641) });
        }
    }
}
