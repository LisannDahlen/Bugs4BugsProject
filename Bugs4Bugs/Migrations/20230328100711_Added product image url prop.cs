using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bugs4Bugs.Migrations
{
    /// <inheritdoc />
    public partial class Addedproductimageurlprop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_BuggTypes_BuggTypeId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Products_ProductId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Statuses_StatusId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Urgencies_UrgencyId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "UrgencyId",
                table: "Tickets",
                newName: "TicketUrgencyId");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Tickets",
                newName: "TicketStatusId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Tickets",
                newName: "TicketProductId");

            migrationBuilder.RenameColumn(
                name: "BuggTypeId",
                table: "Tickets",
                newName: "TicketBugTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_UrgencyId",
                table: "Tickets",
                newName: "IX_Tickets_TicketUrgencyId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                newName: "IX_Tickets_TicketStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ProductId",
                table: "Tickets",
                newName: "IX_Tickets_TicketProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_BuggTypeId",
                table: "Tickets",
                newName: "IX_Tickets_TicketBugTypeId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Statuses",
                newName: "TicketStatus");

            migrationBuilder.AddColumn<string>(
                name: "PhotoURL",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_BuggTypes_TicketBugTypeId",
                table: "Tickets",
                column: "TicketBugTypeId",
                principalTable: "BuggTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Products_TicketProductId",
                table: "Tickets",
                column: "TicketProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Statuses_TicketStatusId",
                table: "Tickets",
                column: "TicketStatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Urgencies_TicketUrgencyId",
                table: "Tickets",
                column: "TicketUrgencyId",
                principalTable: "Urgencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_BuggTypes_TicketBugTypeId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Products_TicketProductId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Statuses_TicketStatusId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Urgencies_TicketUrgencyId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PhotoURL",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "TicketUrgencyId",
                table: "Tickets",
                newName: "UrgencyId");

            migrationBuilder.RenameColumn(
                name: "TicketStatusId",
                table: "Tickets",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "TicketProductId",
                table: "Tickets",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "TicketBugTypeId",
                table: "Tickets",
                newName: "BuggTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_TicketUrgencyId",
                table: "Tickets",
                newName: "IX_Tickets_UrgencyId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_TicketStatusId",
                table: "Tickets",
                newName: "IX_Tickets_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_TicketProductId",
                table: "Tickets",
                newName: "IX_Tickets_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_TicketBugTypeId",
                table: "Tickets",
                newName: "IX_Tickets_BuggTypeId");

            migrationBuilder.RenameColumn(
                name: "TicketStatus",
                table: "Statuses",
                newName: "Status");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_BuggTypes_BuggTypeId",
                table: "Tickets",
                column: "BuggTypeId",
                principalTable: "BuggTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Products_ProductId",
                table: "Tickets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Statuses_StatusId",
                table: "Tickets",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Urgencies_UrgencyId",
                table: "Tickets",
                column: "UrgencyId",
                principalTable: "Urgencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
