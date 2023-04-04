using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class technician : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb525787-f9bd-4d4f-ba5e-a60e16c30a4b", "072299ff-38e6-4a1e-a138-7e623964f3db" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc9296bf-0bc1-4cc3-96e9-36c439ddbdd7", "2e142bb5-4f05-4be6-b008-2b33a1575c57" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a12fce08-b336-458d-a37d-87da9da595d5", "45240b4c-fab0-477e-be2a-9919bd3a6887" });

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a12fce08-b336-458d-a37d-87da9da595d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb525787-f9bd-4d4f-ba5e-a60e16c30a4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc9296bf-0bc1-4cc3-96e9-36c439ddbdd7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "072299ff-38e6-4a1e-a138-7e623964f3db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e142bb5-4f05-4be6-b008-2b33a1575c57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45240b4c-fab0-477e-be2a-9919bd3a6887");

            migrationBuilder.AddColumn<string>(
                name: "TechnicianId",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TechnicianId",
                table: "Tickets",
                column: "TechnicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_TechnicianId",
                table: "Tickets",
                column: "TechnicianId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_TechnicianId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_TechnicianId",
                table: "Tickets");

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

            migrationBuilder.DropColumn(
                name: "TechnicianId",
                table: "Tickets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a12fce08-b336-458d-a37d-87da9da595d5", null, "User", "USER" },
                    { "cb525787-f9bd-4d4f-ba5e-a60e16c30a4b", null, "Owner", "OWNER" },
                    { "dc9296bf-0bc1-4cc3-96e9-36c439ddbdd7", null, "Technician", "TECHNICIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "072299ff-38e6-4a1e-a138-7e623964f3db", 0, "eb42fa2b-382e-43a8-b632-feb7fa3042b6", null, false, "Owen", "Er", false, null, "OWENER@MAIL.COM", "OWENER", "AQAAAAIAAYagAAAAEAOSoOvkaE+au8OEq7sZfW4EdPJxlXpTQTKU/osg93JliurBJi4Z7ljqZP+GZ/hU6g==", null, false, "18993d85-373e-4585-881d-14e6e03292aa", false, "OwenEr" },
                    { "2e142bb5-4f05-4be6-b008-2b33a1575c57", 0, "34a29e76-dc31-435d-8723-08edd255b554", null, false, "Dev", "Code", false, null, "TECHNICHIAN@MAIL.COM", "DEVCODE", "AQAAAAIAAYagAAAAEJMXi8t5/2r++ra8liQonFUkWm3xP10lpDpo6tVOBB/CxNe/RirFkICYYEK/yki7xw==", null, false, "cd256f07-296f-4b5f-bcdd-b63f5e8687df", false, "DevCode" },
                    { "45240b4c-fab0-477e-be2a-9919bd3a6887", 0, "7afd0306-1ba7-4b39-a829-faa2b9c5626c", null, false, "John", "Connor", false, null, "USER@MAIL.COM", "JOHNCONNOR", "AQAAAAIAAYagAAAAEO/FoLy0FPhTDUnG1WiA1T8IEPRL3eHdZmLZ7l2uzhfObRcNQjPqDOXqEq4xW7qtYg==", null, false, "b206ff8f-c4fd-4b5e-9484-0a9ee8bdab08", false, "JohnConnor" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Description", "LastUpdated", "SubmittedDate", "SubmitterId", "TicketBugTypeId", "TicketProductId", "TicketStatusId", "TicketUrgencyId", "Title" },
                values: new object[,]
                {
                    { 1, "En smältande polis jagar mig och en Österrikisk bodybuilder säger att jag ska rädda framtiden", new DateTime(2023, 4, 11, 11, 12, 49, 296, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 4, 7, 11, 12, 49, 296, DateTimeKind.Local).AddTicks(5103), "defaultUser", 1, 5, 1, 1, "Mördarrobotar" },
                    { 2, "Jag gjorde min matteläxa när programmet plötsligt", new DateTime(2023, 4, 4, 11, 12, 49, 296, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 4, 4, 11, 12, 49, 296, DateTimeKind.Local).AddTicks(5183), "defaultUser", 3, 1, 3, 2, "Programmet åt min läxa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cb525787-f9bd-4d4f-ba5e-a60e16c30a4b", "072299ff-38e6-4a1e-a138-7e623964f3db" },
                    { "dc9296bf-0bc1-4cc3-96e9-36c439ddbdd7", "2e142bb5-4f05-4be6-b008-2b33a1575c57" },
                    { "a12fce08-b336-458d-a37d-87da9da595d5", "45240b4c-fab0-477e-be2a-9919bd3a6887" }
                });
        }
    }
}
