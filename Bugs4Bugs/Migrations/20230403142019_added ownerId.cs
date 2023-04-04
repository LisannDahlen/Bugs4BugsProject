using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class addedownerId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defaultDeveloper",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e48acb72-c188-4ee5-ae31-9bf2905b9a83", "AQAAAAIAAYagAAAAEBOwraAXZ2t4kqwZix760KXSwsHq79Uej1UhUo5KIT9t7cmeBopnhT2+kjFr61wnGA==", "3ea79bc1-543a-4e8e-9d1f-85a4021c1a51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defaultOwner",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d40b7243-fe1d-451b-a13d-503f2a012335", "AQAAAAIAAYagAAAAEDvnUqbkSMo0pmMzVD1PM1wk6DuMDogZz2u5JRCKwqCm2vP4bgZvlgrgB6G0fzCtOA==", "2c1fd222-4832-45a8-ad30-d2c2991bd7d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defaultUser",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dcde5e4-e888-4e14-9332-6a63dee250f4", "AQAAAAIAAYagAAAAEG7VISv8FNsC1AjLFvpL/b2Qk2axA8uQrXw15JPlbYthh4scuryCMXa3pMkj0qfe4w==", "49f4f132-0786-4d1b-b225-e20b81c89841" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "OwnerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 10, 16, 20, 19, 93, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 4, 6, 16, 20, 19, 93, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 3, 16, 20, 19, 93, DateTimeKind.Local).AddTicks(7356), new DateTime(2023, 4, 3, 16, 20, 19, 93, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_OwnerId",
                table: "Products",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_OwnerId",
                table: "Products",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_OwnerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OwnerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defaultDeveloper",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e1cfce5-12ae-4a96-94eb-d0679601939e", "AQAAAAIAAYagAAAAECiiHi73liPw0NRzU+2JZMRDoi3I/504RmsNNKShcAHlBxx9N6cqhuTisCYH9M7fYg==", "a9326ab5-a422-42e4-a78e-2de5bfa1d647" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defaultOwner",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "954bd290-d091-41e3-900f-6545dda508ce", "AQAAAAIAAYagAAAAECajnVPqnyn4Q9ESMyJWXP71pGToVU1JUN6+O29LndX4jYE02JTWsW8yVDy5Pqf5sw==", "fddb81c9-df2e-4fb0-a8af-9dfa14ae6f50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defaultUser",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aeb1066b-f10f-4cf4-8b15-df7153dff986", "AQAAAAIAAYagAAAAENFbPoWzVw2IpPMtEmrykq2/iIGSSbERoQdAfqbNZTmrDEakL2Cr6wSoWac1iHGkOA==", "b0d0ccda-d7f3-4f31-83e3-f75e69e63b83" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 10, 15, 49, 40, 411, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 4, 6, 15, 49, 40, 411, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 3, 15, 49, 40, 411, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 4, 3, 15, 49, 40, 411, DateTimeKind.Local).AddTicks(1610) });
        }
    }
}
