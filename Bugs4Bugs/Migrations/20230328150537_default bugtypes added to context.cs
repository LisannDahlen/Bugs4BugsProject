using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class defaultbugtypesaddedtocontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiteUserRole_AspNetUsers_SiteUserId1",
                table: "SiteUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_DeveloperId1",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_SubmitterId1",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "ProductRole");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_DeveloperId1",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_SubmitterId1",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_SiteUserRole_SiteUserId1",
                table: "SiteUserRole");

            migrationBuilder.DropColumn(
                name: "DeveloperId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "DeveloperId1",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SubmitterId1",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SiteUserId1",
                table: "SiteUserRole");

            migrationBuilder.AlterColumn<string>(
                name: "SubmitterId",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SiteUserId",
                table: "SiteUserRole",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BuggTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "BuggTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[,]
                {
                    { 1, null, "Program crash" },
                    { 2, null, "Visual glitch" },
                    { 3, null, "Performance issue" },
                    { 4, null, "Unexpected behaviour" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SubmitterId",
                table: "Tickets",
                column: "SubmitterId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteUserRole_SiteUserId",
                table: "SiteUserRole",
                column: "SiteUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SiteUserRole_AspNetUsers_SiteUserId",
                table: "SiteUserRole",
                column: "SiteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_SubmitterId",
                table: "Tickets",
                column: "SubmitterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiteUserRole_AspNetUsers_SiteUserId",
                table: "SiteUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_SubmitterId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_SubmitterId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_SiteUserRole_SiteUserId",
                table: "SiteUserRole");

            migrationBuilder.DeleteData(
                table: "BuggTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BuggTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BuggTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BuggTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<int>(
                name: "SubmitterId",
                table: "Tickets",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "DeveloperId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeveloperId1",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubmitterId1",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SiteUserId",
                table: "SiteUserRole",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "SiteUserId1",
                table: "SiteUserRole",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BuggTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProductRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    SiteUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductRole_AspNetUsers_SiteUserId",
                        column: x => x.SiteUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductRole_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DeveloperId1",
                table: "Tickets",
                column: "DeveloperId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SubmitterId1",
                table: "Tickets",
                column: "SubmitterId1");

            migrationBuilder.CreateIndex(
                name: "IX_SiteUserRole_SiteUserId1",
                table: "SiteUserRole",
                column: "SiteUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRole_ProductId",
                table: "ProductRole",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRole_RoleId",
                table: "ProductRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRole_SiteUserId",
                table: "ProductRole",
                column: "SiteUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SiteUserRole_AspNetUsers_SiteUserId1",
                table: "SiteUserRole",
                column: "SiteUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_DeveloperId1",
                table: "Tickets",
                column: "DeveloperId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_SubmitterId1",
                table: "Tickets",
                column: "SubmitterId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
