using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class addeddefaultproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "70c6fb52-24d8-44af-955e-177793a889a6", "54036719-a5cf-48bd-a175-5af3c893e055" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cf12772b-d7b7-40ff-aa74-a1736867ae18", "779efd5d-ce78-41b8-a7de-2fa7eaafb957" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d7b5987f-38a4-4963-8ba7-a0b6f183c045", "79a474df-758b-4b0e-8b30-79a7dfed9af9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70c6fb52-24d8-44af-955e-177793a889a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf12772b-d7b7-40ff-aa74-a1736867ae18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7b5987f-38a4-4963-8ba7-a0b6f183c045");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54036719-a5cf-48bd-a175-5af3c893e055");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "779efd5d-ce78-41b8-a7de-2fa7eaafb957");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79a474df-758b-4b0e-8b30-79a7dfed9af9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a84d891-552a-4b22-9ed9-428829191a63", null, "User", "USER" },
                    { "5865b70f-7fe6-442f-a315-da09f3c6b5c6", null, "Technician", "TECHNICIAN" },
                    { "a32cefbc-9a7e-4772-abf9-c8f7520297b1", null, "Owner", "OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "78c5634f-da84-40e0-a99d-e3f799137dc4", 0, "f1995b21-d0d7-45e2-833e-14f350cbe2df", null, false, "Owen", "Er", false, null, "OWENER@MAIL.COM", "OWENER", "AQAAAAIAAYagAAAAEKCPEbujRs1OEgOjvIRVLROblE7xUWt+Ns3zFoL55cDt7du9n0V/LNqPJSg1sBUU2g==", null, false, "57789c37-19b5-45fb-ba98-d1fa2b96f69f", false, "OwenEr" },
                    { "a6ac9232-614c-486e-9ed8-15cec85c0446", 0, "733ba214-b5c0-454a-b540-3418c41f75ae", null, false, "Dev", "Code", false, null, "TECHNICHIAN@MAIL.COM", "DEVCODE", "AQAAAAIAAYagAAAAENhgD1qTrX9IA3nmjaBr0UJoJgFPjhYJgXCWIfYV4pAmKphr85daDxQKUq28p06TIQ==", null, false, "16668633-d38e-4bfb-b2db-c50b8fdb5942", false, "DevCode" },
                    { "b4251ea0-70e6-46e4-81e9-7961e5459a8d", 0, "a1bbc68c-eb47-4e51-8acc-e5d3488bdcae", null, false, "John", "Connor", false, null, "USER@MAIL.COM", "JOHNCONNOR", "AQAAAAIAAYagAAAAEGHvsTE+pi6vIIRG5efqokBtBhmx1q3GoDIOZUtIu6Xz9br4MQ1mm5f4Sl9+XRGEow==", null, false, "7c0a4376-8bec-4a0c-9d80-d2d3f88b4c2f", false, "JohnConnor" }
                });

            migrationBuilder.InsertData(
                table: "BuggTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { 5, null, "Broken feature" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Description", "LastUpdated", "SubmittedDate", "SubmitterId", "TechnicianId", "TicketBugTypeId", "TicketProductId", "TicketStatusId", "TicketUrgencyId", "Title" },
                values: new object[,]
                {
                    { 1, "Whenever I try to open my project, the visual studio screen freezes", new DateTime(2023, 4, 18, 15, 9, 59, 892, DateTimeKind.Local).AddTicks(4818), new DateTime(2023, 4, 18, 15, 9, 59, 892, DateTimeKind.Local).AddTicks(4774), "1a84d891-552a-4b22-9ed9-428829191a63", null, 3, 1, 3, 1, "Screen freezes" },
                    { 3, "All Harry Potter movies are missing. Huge problem!", new DateTime(2023, 4, 18, 15, 9, 59, 892, DateTimeKind.Local).AddTicks(4827), new DateTime(2023, 4, 18, 15, 9, 59, 892, DateTimeKind.Local).AddTicks(4825), "1a84d891-552a-4b22-9ed9-428829191a63", null, 3, 7, 3, 4, "Harry Potter is missing" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a32cefbc-9a7e-4772-abf9-c8f7520297b1", "78c5634f-da84-40e0-a99d-e3f799137dc4" },
                    { "5865b70f-7fe6-442f-a315-da09f3c6b5c6", "a6ac9232-614c-486e-9ed8-15cec85c0446" },
                    { "1a84d891-552a-4b22-9ed9-428829191a63", "b4251ea0-70e6-46e4-81e9-7961e5459a8d" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Description", "LastUpdated", "SubmittedDate", "SubmitterId", "TechnicianId", "TicketBugTypeId", "TicketProductId", "TicketStatusId", "TicketUrgencyId", "Title" },
                values: new object[] { 2, "When I start a meeting, it is not visible for anyone else, not even for me", new DateTime(2023, 4, 18, 15, 9, 59, 892, DateTimeKind.Local).AddTicks(4823), new DateTime(2023, 4, 18, 15, 9, 59, 892, DateTimeKind.Local).AddTicks(4821), "1a84d891-552a-4b22-9ed9-428829191a63", null, 5, 11, 3, 3, "Cant see teams meeting" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a32cefbc-9a7e-4772-abf9-c8f7520297b1", "78c5634f-da84-40e0-a99d-e3f799137dc4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5865b70f-7fe6-442f-a315-da09f3c6b5c6", "a6ac9232-614c-486e-9ed8-15cec85c0446" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a84d891-552a-4b22-9ed9-428829191a63", "b4251ea0-70e6-46e4-81e9-7961e5459a8d" });

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a84d891-552a-4b22-9ed9-428829191a63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5865b70f-7fe6-442f-a315-da09f3c6b5c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a32cefbc-9a7e-4772-abf9-c8f7520297b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c5634f-da84-40e0-a99d-e3f799137dc4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6ac9232-614c-486e-9ed8-15cec85c0446");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4251ea0-70e6-46e4-81e9-7961e5459a8d");

            migrationBuilder.DeleteData(
                table: "BuggTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70c6fb52-24d8-44af-955e-177793a889a6", null, "Owner", "OWNER" },
                    { "cf12772b-d7b7-40ff-aa74-a1736867ae18", null, "Technician", "TECHNICIAN" },
                    { "d7b5987f-38a4-4963-8ba7-a0b6f183c045", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "54036719-a5cf-48bd-a175-5af3c893e055", 0, "370e134f-9a92-4e75-b9f3-0b1c4b29c2b6", null, false, "Owen", "Er", false, null, "OWENER@MAIL.COM", "OWENER", "AQAAAAIAAYagAAAAEPchTHHp4ONIaXqIJYxmUK7UkAUiiarFf4qpQBasyEjJnGi/1VLOyhizNhKxXbZCXg==", null, false, "def35380-69e4-4201-aea6-876cddbb0f58", false, "OwenEr" },
                    { "779efd5d-ce78-41b8-a7de-2fa7eaafb957", 0, "5c074c6f-1e98-40f0-bb3c-2fdf42c751f6", null, false, "Dev", "Code", false, null, "TECHNICHIAN@MAIL.COM", "DEVCODE", "AQAAAAIAAYagAAAAEJtL/DW+Ks0koTugTqNLRdLhisGYSiouQ7vf9AKKuBoAr8s1aTZwphMq8RHDq6ULMA==", null, false, "c3167308-7945-4dc7-84d8-2bfc631985fe", false, "DevCode" },
                    { "79a474df-758b-4b0e-8b30-79a7dfed9af9", 0, "45cadc2e-71ed-4160-94fd-7dfd397aa028", null, false, "John", "Connor", false, null, "USER@MAIL.COM", "JOHNCONNOR", "AQAAAAIAAYagAAAAEFScN7l2ree9+/vDmN1P568ZDQcZNmhdwz7PpZ3ll3XMh8HPhyPsNk1zcvogsYtaag==", null, false, "3e4ba47a-0a91-473e-bfe6-9844e75be40e", false, "JohnConnor" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "70c6fb52-24d8-44af-955e-177793a889a6", "54036719-a5cf-48bd-a175-5af3c893e055" },
                    { "cf12772b-d7b7-40ff-aa74-a1736867ae18", "779efd5d-ce78-41b8-a7de-2fa7eaafb957" },
                    { "d7b5987f-38a4-4963-8ba7-a0b6f183c045", "79a474df-758b-4b0e-8b30-79a7dfed9af9" }
                });
        }
    }
}
