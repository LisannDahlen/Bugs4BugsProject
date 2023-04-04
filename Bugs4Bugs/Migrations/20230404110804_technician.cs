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
                keyValues: new object[] { "TechnicianRoleId", "defaultDeveloper" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ManagerRoleId", "defaultOwner" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "UserRoleId", "defaultUser" });

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
                keyValue: "ManagerRoleId");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "TechnicianRoleId");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "UserRoleId");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defaultDeveloper");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defaultOwner");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defaultUser");

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
                    { "0020526e-dbb1-4162-80c0-282908a3dc6a", null, "User", "USER" },
                    { "14488ddd-1f16-41a0-b6fa-70da9fb826c7", null, "Technician", "TECHNICIAN" },
                    { "9ea77062-d470-4774-8090-84b3f74273a9", null, "Owner", "OWNER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3903c0b1-f4b5-40eb-b171-4723bb372538", 0, "daf42732-7a08-4e9d-b810-192375644898", null, false, "John", "Connor", false, null, "USER@MAIL.COM", "JOHNCONNOR", "AQAAAAIAAYagAAAAEC5cttYR+PcbuaT8RKCSH/UFmIQGObG9S8dIeSbikwIKlJvtaRAv7jokodZkHvSf/g==", null, false, "5023651a-3464-4ca1-912b-2377dac3abed", false, "JohnConnor" },
                    { "77dfe50f-9c83-49d3-8eeb-5eef4585f9c2", 0, "87cb7c43-ecdf-4bc2-b301-75b67eb7b8da", null, false, "Owen", "Er", false, null, "OWENER@MAIL.COM", "OWENER", "AQAAAAIAAYagAAAAEFppLtctHv0ro8hTnHvaDL0856lKiSE/pIU/bd5atuyFNdU1vBCFYcZ4ofTAYY6xZQ==", null, false, "21343fe9-1458-403b-99d2-3bed4eba6deb", false, "OwenEr" },
                    { "ad59bbc5-ef03-4922-bb60-291eb9b70160", 0, "5845f937-f584-46b9-948a-8afeab80d0cf", null, false, "Dev", "Code", false, null, "TECHNICHIAN@MAIL.COM", "DEVCODE", "AQAAAAIAAYagAAAAEPPLsbSUJfxN9kCBGV8K39RC9dDaf7iPHZ+wp+iwus+b6LKT0wMMm3yS0S6erBxteQ==", null, false, "f49f802b-7b5f-469b-a957-430e77c9b3af", false, "DevCode" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0020526e-dbb1-4162-80c0-282908a3dc6a", "3903c0b1-f4b5-40eb-b171-4723bb372538" },
                    { "9ea77062-d470-4774-8090-84b3f74273a9", "77dfe50f-9c83-49d3-8eeb-5eef4585f9c2" },
                    { "14488ddd-1f16-41a0-b6fa-70da9fb826c7", "ad59bbc5-ef03-4922-bb60-291eb9b70160" }
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
                keyValues: new object[] { "0020526e-dbb1-4162-80c0-282908a3dc6a", "3903c0b1-f4b5-40eb-b171-4723bb372538" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ea77062-d470-4774-8090-84b3f74273a9", "77dfe50f-9c83-49d3-8eeb-5eef4585f9c2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14488ddd-1f16-41a0-b6fa-70da9fb826c7", "ad59bbc5-ef03-4922-bb60-291eb9b70160" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0020526e-dbb1-4162-80c0-282908a3dc6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14488ddd-1f16-41a0-b6fa-70da9fb826c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ea77062-d470-4774-8090-84b3f74273a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3903c0b1-f4b5-40eb-b171-4723bb372538");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77dfe50f-9c83-49d3-8eeb-5eef4585f9c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad59bbc5-ef03-4922-bb60-291eb9b70160");

            migrationBuilder.DropColumn(
                name: "TechnicianId",
                table: "Tickets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ManagerRoleId", null, "Manager", "MANAGER" },
                    { "TechnicianRoleId", null, "Technician", "TECHNICIAN" },
                    { "UserRoleId", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "defaultDeveloper", 0, "e48acb72-c188-4ee5-ae31-9bf2905b9a83", null, false, "Dev", "Code", false, null, null, null, "AQAAAAIAAYagAAAAEBOwraAXZ2t4kqwZix760KXSwsHq79Uej1UhUo5KIT9t7cmeBopnhT2+kjFr61wnGA==", null, false, "3ea79bc1-543a-4e8e-9d1f-85a4021c1a51", false, "DevCode" },
                    { "defaultOwner", 0, "d40b7243-fe1d-451b-a13d-503f2a012335", null, false, "Owen", "Er", false, null, null, null, "AQAAAAIAAYagAAAAEDvnUqbkSMo0pmMzVD1PM1wk6DuMDogZz2u5JRCKwqCm2vP4bgZvlgrgB6G0fzCtOA==", null, false, "2c1fd222-4832-45a8-ad30-d2c2991bd7d9", false, "OwenEr" },
                    { "defaultUser", 0, "0dcde5e4-e888-4e14-9332-6a63dee250f4", null, false, "John", "Connor", false, null, null, null, "AQAAAAIAAYagAAAAEG7VISv8FNsC1AjLFvpL/b2Qk2axA8uQrXw15JPlbYthh4scuryCMXa3pMkj0qfe4w==", null, false, "49f4f132-0786-4d1b-b225-e20b81c89841", false, "JohnConnor" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "TechnicianRoleId", "defaultDeveloper" },
                    { "ManagerRoleId", "defaultOwner" },
                    { "UserRoleId", "defaultUser" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Description", "LastUpdated", "SubmittedDate", "SubmitterId", "TicketBugTypeId", "TicketProductId", "TicketStatusId", "TicketUrgencyId", "Title" },
                values: new object[,]
                {
                    { 1, "En smältande polis jagar mig och en Österrikisk bodybuilder säger att jag ska rädda framtiden", new DateTime(2023, 4, 10, 16, 20, 19, 93, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 4, 6, 16, 20, 19, 93, DateTimeKind.Local).AddTicks(7259), "defaultUser", 1, 5, 1, 1, "Mördarrobotar" },
                    { 2, "Jag gjorde min matteläxa när programmet plötsligt", new DateTime(2023, 4, 3, 16, 20, 19, 93, DateTimeKind.Local).AddTicks(7356), new DateTime(2023, 4, 3, 16, 20, 19, 93, DateTimeKind.Local).AddTicks(7355), "defaultUser", 3, 1, 3, 2, "Programmet åt min läxa" }
                });
        }
    }
}
