using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class updatedmodelclasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Urgencies",
                newName: "Level");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Statuses",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BuggTypes",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Urgencies",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "SubmitterId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubmitterId1",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Statuses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "SiteUserRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteUserId = table.Column<int>(type: "int", nullable: false),
                    SiteUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleInProductId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteUserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SiteUserRole_AspNetUsers_SiteUserId1",
                        column: x => x.SiteUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteUserRole_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SiteUserRole_Role_RoleInProductId",
                        column: x => x.RoleInProductId,
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

            migrationBuilder.CreateIndex(
                name: "IX_SiteUserRole_ProductId",
                table: "SiteUserRole",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteUserRole_RoleInProductId",
                table: "SiteUserRole",
                column: "RoleInProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteUserRole_SiteUserId1",
                table: "SiteUserRole",
                column: "SiteUserId1");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_DeveloperId1",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_SubmitterId1",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "ProductRole");

            migrationBuilder.DropTable(
                name: "SiteUserRole");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_DeveloperId1",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_SubmitterId1",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Urgencies");

            migrationBuilder.DropColumn(
                name: "DeveloperId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "DeveloperId1",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SubmitterId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "SubmitterId1",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Urgencies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Statuses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "BuggTypes",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Statuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
