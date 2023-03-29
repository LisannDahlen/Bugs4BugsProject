using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class Defaultuserandtickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "DefaultId", 0, "0a2751c8-fc8a-478c-9013-dcf4340d1eae", null, false, "John", "Connor", false, null, null, null, null, null, false, "2b87d918-dd33-4caf-8f90-3319b1bcf51f", false, "JohnConnor" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Description", "LastUpdated", "SubmittedDate", "SubmitterId", "TicketBugTypeId", "TicketProductId", "TicketStatusId", "TicketUrgencyId", "Title" },
                values: new object[,]
                {
                    { 1, "En smältande polis jagar mig och en Österrikisk bodybuilder säger att jag ska rädda framtiden", new DateTime(2023, 4, 5, 14, 3, 34, 790, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 4, 1, 14, 3, 34, 790, DateTimeKind.Local).AddTicks(4442), "DefaultId", 1, 5, 1, 1, "Mördarrobotar" },
                    { 2, "Jag gjorde min matteläxa när programmet plötsligt", new DateTime(2023, 3, 29, 14, 3, 34, 790, DateTimeKind.Local).AddTicks(4542), new DateTime(2023, 3, 29, 14, 3, 34, 790, DateTimeKind.Local).AddTicks(4540), "DefaultId", 3, 1, 3, 2, "Programmet åt min läxa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId");
        }
    }
}
