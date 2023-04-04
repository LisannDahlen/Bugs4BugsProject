using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class Defaultuserswithroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defaultDeveloper");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DefaultId");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defaultOwner");

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

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 11, 11, 12, 49, 296, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 4, 7, 11, 12, 49, 296, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastUpdated", "SubmittedDate" },
                values: new object[] { new DateTime(2023, 4, 4, 11, 12, 49, 296, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 4, 4, 11, 12, 49, 296, DateTimeKind.Local).AddTicks(5183) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "defaultDeveloper", 0, "e48acb72-c188-4ee5-ae31-9bf2905b9a83", null, false, "Dev", "Code", false, null, null, null, "AQAAAAIAAYagAAAAEBOwraAXZ2t4kqwZix760KXSwsHq79Uej1UhUo5KIT9t7cmeBopnhT2+kjFr61wnGA==", null, false, "3ea79bc1-543a-4e8e-9d1f-85a4021c1a51", false, "DevCode" },
                    { "DefaultId", 0, "0dcde5e4-e888-4e14-9332-6a63dee250f4", null, false, "John", "Connor", false, null, null, null, "AQAAAAIAAYagAAAAEG7VISv8FNsC1AjLFvpL/b2Qk2axA8uQrXw15JPlbYthh4scuryCMXa3pMkj0qfe4w==", null, false, "49f4f132-0786-4d1b-b225-e20b81c89841", false, "JohnConnor" },
                    { "defaultOwner", 0, "d40b7243-fe1d-451b-a13d-503f2a012335", null, false, "Owen", "Er", false, null, null, null, "AQAAAAIAAYagAAAAEDvnUqbkSMo0pmMzVD1PM1wk6DuMDogZz2u5JRCKwqCm2vP4bgZvlgrgB6G0fzCtOA==", null, false, "2c1fd222-4832-45a8-ad30-d2c2991bd7d9", false, "OwenEr" }
                });

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
        }
    }
}
