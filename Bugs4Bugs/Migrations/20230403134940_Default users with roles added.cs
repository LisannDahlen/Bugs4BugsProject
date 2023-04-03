using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class Defaultuserswithrolesadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId");

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
                    { "defaultDeveloper", 0, "7e1cfce5-12ae-4a96-94eb-d0679601939e", null, false, "Dev", "Code", false, null, null, null, "AQAAAAIAAYagAAAAECiiHi73liPw0NRzU+2JZMRDoi3I/504RmsNNKShcAHlBxx9N6cqhuTisCYH9M7fYg==", null, false, "a9326ab5-a422-42e4-a78e-2de5bfa1d647", false, "DevCode" },
                    { "defaultOwner", 0, "954bd290-d091-41e3-900f-6545dda508ce", null, false, "Owen", "Er", false, null, null, null, "AQAAAAIAAYagAAAAECajnVPqnyn4Q9ESMyJWXP71pGToVU1JUN6+O29LndX4jYE02JTWsW8yVDy5Pqf5sw==", null, false, "fddb81c9-df2e-4fb0-a8af-9dfa14ae6f50", false, "OwenEr" },
                    { "defaultUser", 0, "aeb1066b-f10f-4cf4-8b15-df7153dff986", null, false, "John", "Connor", false, null, null, null, "AQAAAAIAAYagAAAAENFbPoWzVw2IpPMtEmrykq2/iIGSSbERoQdAfqbNZTmrDEakL2Cr6wSoWac1iHGkOA==", null, false, "b0d0ccda-d7f3-4f31-83e3-f75e69e63b83", false, "JohnConnor" }
                });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate", "SubmitterId" },
                values: new object[] { new DateTime(2023, 4, 10, 15, 49, 40, 411, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 4, 6, 15, 49, 40, 411, DateTimeKind.Local).AddTicks(1540), "defaultUser" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate", "SubmitterId" },
                values: new object[] { new DateTime(2023, 4, 3, 15, 49, 40, 411, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 4, 3, 15, 49, 40, 411, DateTimeKind.Local).AddTicks(1610), "defaultUser" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "TechnicianRoleId", "defaultDeveloper" },
                    { "ManagerRoleId", "defaultOwner" },
                    { "UserRoleId", "defaultUser" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "DefaultId", 0, "67a5c16d-18a1-4d09-b779-8c03677bcc19", null, false, "John", "Connor", false, null, null, null, null, null, false, "e04bae74-5a54-4675-a4a8-e6a634d8b9f0", false, "JohnConnor" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate", "SubmitterId" },
                values: new object[] { new DateTime(2023, 4, 10, 10, 37, 34, 678, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 4, 6, 10, 37, 34, 678, DateTimeKind.Local).AddTicks(4384), "DefaultId" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate", "SubmitterId" },
                values: new object[] { new DateTime(2023, 4, 3, 10, 37, 34, 678, DateTimeKind.Local).AddTicks(4442), new DateTime(2023, 4, 3, 10, 37, 34, 678, DateTimeKind.Local).AddTicks(4440), "DefaultId" });
        }
    }
}
